using System;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Mathway
{
    public partial class Form1 : Form
    {
        private const double DEFAULT_X_MIN = -10.0;
        private const double DEFAULT_X_MAX = 10.0;
        private const double DEFAULT_X_STEP = 0.1;
        private const int DEFAULT_A_VALUE = 1;
        private const int DEFAULT_B_VALUE = 0;
        private const string DEFAULT_FUNCTION = "y=sin(x)";

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
            SetDefaultValues();
            UpdatePlot();
        }

        private void InitializeCustomComponents()
        {
            plotView.Model = new PlotModel { Title = "График функции" };
            plotView.Model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "X", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot });
            plotView.Model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Y", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot });

            // Привязка событий для автоматического обновления
            sliderA.ValueChanged += Parameter_Changed;
            sliderB.ValueChanged += Parameter_Changed;
            xMinNumeric.ValueChanged += Parameter_Changed;
            xMaxNumeric.ValueChanged += Parameter_Changed;
            xStepNumeric.ValueChanged += Parameter_Changed;
            inputTextBox.TextChanged += InputTextBox_TextChanged_Delayed;

            sliderA.Minimum = -10;
            sliderA.Maximum = 10;
            sliderA.SmallChange = 1;
            sliderA.LargeChange = 1;


            sliderB.Minimum = -10;
            sliderB.Maximum = 10;
            sliderB.SmallChange = 1;
            sliderB.LargeChange = 1;

            xMinNumeric.Minimum = -1000;
            xMinNumeric.Maximum = 1000;
            xMinNumeric.DecimalPlaces = 2;
            xMinNumeric.Increment = 0.1m;

            xMaxNumeric.Minimum = -1000;
            xMaxNumeric.Maximum = 1000;
            xMaxNumeric.DecimalPlaces = 2;
            xMaxNumeric.Increment = 0.1m;

            xStepNumeric.Minimum = 0.01m;
            xStepNumeric.Maximum = 10;
            xStepNumeric.DecimalPlaces = 3;
            xStepNumeric.Increment = 0.01m;

            plotButton.Click -= PlotButton_Click;
            plotButton.Click += (s, e) => UpdatePlot();

            resetButton.Click += ResetButton_Click;
        }

        private void SetDefaultValues()
        {
            inputTextBox.Text = DEFAULT_FUNCTION;
            sliderA.Value = DEFAULT_A_VALUE;
            sliderB.Value = DEFAULT_B_VALUE;
            xMinNumeric.Value = (decimal)DEFAULT_X_MIN;
            xMaxNumeric.Value = (decimal)DEFAULT_X_MAX;
            xStepNumeric.Value = (decimal)DEFAULT_X_STEP;

            UpdateSliderLabels();
        }

        private void UpdateSliderLabels()
        {
            cofALabel.Text = $"a: {sliderA.Value}";
            cofBLabel.Text = $"b: {sliderB.Value}";
        }

        private void Parameter_Changed(object sender, EventArgs e)
        {
            UpdateSliderLabels();
            UpdatePlot();
        }

        private Timer _inputDebounceTimer;
        private void InputTextBox_TextChanged_Delayed(object sender, EventArgs e)
        {
            if (_inputDebounceTimer == null)
            {
                _inputDebounceTimer = new Timer();
                _inputDebounceTimer.Interval = 750; 
                _inputDebounceTimer.Tick += (s, args) =>
                {
                    _inputDebounceTimer.Stop();
                    UpdatePlot();
                };
            }
            _inputDebounceTimer.Stop();
            _inputDebounceTimer.Start();
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
        }

        private void UpdatePlot()
        {
            try
            {
                string userInput = inputTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    plotView.Model.Series.Clear();
                    plotView.Model.InvalidatePlot(true);
                    return;
                }

                if (!userInput.ToLower().Contains("x"))
                {
                    ShowError("Функция должна содержать переменную 'x'.");
                    return;
                }

                string expression;
                if (userInput.ToLower().StartsWith("y="))
                {
                    expression = userInput.Substring(2).Trim();
                }
                else
                {
                    // Если пользователь ввел просто "sin(x)", считаем, что это "y=sin(x)"
                    expression = userInput;
                }

                if (string.IsNullOrWhiteSpace(expression))
                {
                    ShowError("Выражение функции не может быть пустым после 'y='.");
                    return;
                }


                var model = plotView.Model ?? new PlotModel(); // Используем существующую модель или создаем новую
                model.Title = $"График: {userInput}";
                model.Series.Clear(); // Очищаем предыдущие серии

                var series = new LineSeries
                {
                    Color = OxyColors.DodgerBlue,
                    StrokeThickness = 2,
                    MarkerType = MarkerType.None // Убираем точки, если не нужны
                };

                double a = sliderA.Value;
                double b = sliderB.Value;
                double xMin = (double)xMinNumeric.Value;
                double xMax = (double)xMaxNumeric.Value;
                double xStep = (double)xStepNumeric.Value;

                if (xMin >= xMax)
                {
                    ShowError("Xmin должен быть меньше Xmax.");
                    return;
                }
                if (xStep <= 0)
                {
                    ShowError("Шаг X должен быть положительным.");
                    return;
                }

                bool hasValidPoint = false;
                for (double x = xMin; x <= xMax; x += xStep)
                {
                    // Округляем x, чтобы избежать проблем с точностью double при шаге
                    double currentX = Math.Round(x, 10);
                    try
                    {
                        double y = EvaluateFunction(expression, currentX, a, b);
                        if (double.IsNaN(y) || double.IsInfinity(y))
                        {
                            // Разрыв графика (можно добавить пустую точку или просто пропустить)
                            // series.Points.Add(DataPoint.Undefined); // Для разрыва линии
                            continue;
                        }
                        series.Points.Add(new DataPoint(currentX, y));
                        hasValidPoint = true;
                    }
                    catch (Exception evalEx)
                    {
                        // Если одна точка не вычисляется, пропускаем ее, но не прерываем весь график
                        // Можно логировать ошибку или показать ее один раз
                        Console.WriteLine($"Ошибка вычисления в точке x={currentX}: {evalEx.Message}");
                        // Для разрыва линии при ошибке в точке:
                        // if (series.Points.Count > 0 && series.Points.Last() != DataPoint.Undefined)
                        //    series.Points.Add(DataPoint.Undefined);
                    }
                }

                if (!hasValidPoint && series.Points.Count == 0)
                {
                    ShowError("Не удалось построить график. Возможно, выражение некорректно или все точки вне области определения.");
                    return;
                }

                model.Series.Add(series);

                // Автоматическое масштабирование осей по данным, если нужно
                // model.ResetAllAxes(); // Сбросит текущие настройки масштаба осей
                // model.Axes[0].Minimum = xMin; // Ось X
                // model.Axes[0].Maximum = xMax;
                // Для оси Y можно оставить автоматическое масштабирование или задать вручную

                plotView.Model = model; // Присваиваем модель (важно, если создавали новую)
                plotView.InvalidatePlot(true); // Перерисовываем график
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка построения графика: {ex.Message}");
            }
        }

        private double EvaluateFunction(string expression, double xVal, double aVal, double bVal)
        {
            // 1. Замена констант (важно делать до замены переменных, если имена похожи)
            // Используем Regex для замены только целых слов "pi" и "e", чтобы не затронуть "exp" или "testpie"
            string processedExpression = Regex.Replace(expression, @"\bpi\b", Math.PI.ToString(CultureInfo.InvariantCulture), RegexOptions.IgnoreCase);
            processedExpression = Regex.Replace(processedExpression, @"\be\b", Math.E.ToString(CultureInfo.InvariantCulture), RegexOptions.IgnoreCase);

            // 2. Замена переменных x, a, b на их числовые значения
            // Обязательно используем CultureInfo.InvariantCulture для десятичного разделителя "."
            // Заменяем переменные, убедившись, что они не являются частью других слов (например, "exp" не должно стать "Math.EValxp")
            // Добавляем скобки вокруг отрицательных чисел, чтобы избежать проблем типа "2*-5" -> "2-5"
            string xStr = xVal < 0 ? $"({xVal.ToString(CultureInfo.InvariantCulture)})" : xVal.ToString(CultureInfo.InvariantCulture);
            string aStr = aVal < 0 ? $"({aVal.ToString(CultureInfo.InvariantCulture)})" : aVal.ToString(CultureInfo.InvariantCulture);
            string bStr = bVal < 0 ? $"({bVal.ToString(CultureInfo.InvariantCulture)})" : bVal.ToString(CultureInfo.InvariantCulture);

            processedExpression = Regex.Replace(processedExpression, @"\bx\b", xStr, RegexOptions.IgnoreCase);
            processedExpression = Regex.Replace(processedExpression, @"\ba\b", aStr, RegexOptions.IgnoreCase);
            processedExpression = Regex.Replace(processedExpression, @"\bb\b", bStr, RegexOptions.IgnoreCase);


            // 3. Замена математических функций на их эквиваленты для DataTable.Compute или Math.*
            // DataTable.Compute не поддерживает Math.* напрямую, но поддерживает некоторые функции.
            // Для простоты, если DataTable.Compute не справится, можно рассмотреть NCalc или другие библиотеки.
            // Пока что будем использовать функции, которые DataTable.Compute может понять, или преобразовывать.

            // Возведение в степень: x^2 -> POW(x, 2)
            // Этот Regex ищет (число или переменная) ^ (число или переменная)
            // Он довольно простой и может не покрыть все случаи (например, (x+1)^2)
            // Для более сложных случаев нужен полноценный парсер.
            processedExpression = Regex.Replace(processedExpression,
                @"(\w+|\([\d\.\-]+\))\s*\^\s*(\w+|\([\d\.\-]+\))", // (операнд1)^(операнд2)
                "POW($1, $2)");
            // Повторная обработка для вложенных степеней (например, x^2^3 -> POW(x,2)^3 -> POW(POW(x,2),3))
            processedExpression = Regex.Replace(processedExpression,
               @"POW\(([^)]+)\)\s*\^\s*(\w+|\([\d\.\-]+\))",
               "POW(POW($1), $2)");


            // Стандартные функции (некоторые DataTable.Compute понимает, некоторые нет)
            // DataTable.Compute понимает: Sin, Cos, Tan, Exp, Log (натуральный), Sqrt, Abs, Pow
            // Поэтому замены на Math.* не всегда нужны, если DataTable.Compute их поддерживает.
            // Оставим замены для ясности и если DataTable их не поймет в таком виде.
            // Важно: заменять более длинные имена функций первыми (например, "asin" до "sin")
            processedExpression = processedExpression.Replace("asin", "ASIN") // DataTable может не знать ASIN, это пример
                                       .Replace("acos", "ACOS")
                                       .Replace("atan", "ATAN")
                                       .Replace("sinh", "SINH") // Гиперболические
                                       .Replace("cosh", "COSH")
                                       .Replace("tanh", "TANH")
                                       .Replace("sqrt", "SQRT")
                                       .Replace("abs", "ABS")
                                       .Replace("log10", "LOG10") // DataTable может не знать LOG10
                                       .Replace("log", "LOG")   // Натуральный логарифм в DataTable
                                       .Replace("exp", "EXP")
                                       .Replace("sin", "SIN")
                                       .Replace("cos", "COS")
                                       .Replace("tan", "TAN");
            // Регистр для DataTable.Compute обычно не важен для имен функций

            // Попытка добавить неявное умножение (например, 2x -> 2*x, ax -> a*x)
            // Это очень сложная задача для простого Regex, т.к. нужно отличать от имен функций.
            // Пример: (\d)([a-zA-Z(]) -> $1*$2 (число перед буквой или скобкой)
            // processedExpression = Regex.Replace(processedExpression, @"(\d)([a-zA-Z\(])", "$1*$2");
            // Пример: ([a-zA-Z)])(\() -> $1*$2 (буква или закрывающая скобка перед открывающей)
            // processedExpression = Regex.Replace(processedExpression, @"([a-zA-Z\)])(\()", "$1*$2");
            // ОСТОРОЖНО: Неявное умножение может легко сломать правильные выражения. Лучше требовать явное.

            Console.WriteLine($"Вычисляемое выражение: {processedExpression}"); // Для отладки

            try
            {
                var table = new System.Data.DataTable();
                table.Locale = CultureInfo.InvariantCulture; // Важно для правильного парсинга чисел
                // DataTable.Compute не понимает функции типа ASIN, ACOS, ATAN, LOG10, SINH и т.д.
                // Если нужны эти функции, придется либо реализовывать свой парсер,
                // либо использовать стороннюю библиотеку (NCalc, Jace, DynamicExpresso, mXparser).
                // Для данного примера, ограничимся функциями, которые DataTable.Compute может обработать
                // или которые мы можем эмулировать (как POW).
                // Если функция не поддерживается, DataTable.Compute выдаст ошибку.
                var result = table.Compute(processedExpression, null);
                return Convert.ToDouble(result, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                // Перебрасываем исключение с более информативным сообщением
                throw new ArgumentException($"Ошибка вычисления выражения '{processedExpression}'. Убедитесь в корректности ввода и поддержке всех функций. Исходная ошибка: {ex.Message}", ex);
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Можно также очистить график или выделить поле ввода
            plotView.Model?.Series.Clear();
            plotView.Model?.InvalidatePlot(true);
        }

        // Старый обработчик кнопки, если он был в дизайнере, его можно удалить
        // или оставить пустым, так как мы переопределили его в InitializeCustomComponents
        private void PlotButton_Click(object sender, EventArgs e)
        {
            // Этот метод больше не нужен напрямую, так как UpdatePlot вызывается из других мест
            // или из нового обработчика, назначенного в InitializeCustomComponents.
            // Оставляем на случай, если он где-то еще используется или для обратной совместимости.
            // UpdatePlot();
        }

        // Старые обработчики слайдеров
        private void sliderA_Scroll(object sender, EventArgs e) // ScrollEventArgs для HScrollBar/VScrollBar
        {
            // Заменено на sliderA.ValueChanged и общий Parameter_Changed
            // UpdateSliderLabels();
            // UpdatePlot();
        }

        private void sliderB_Scroll(object sender, EventArgs e)
        {
            // Заменено на sliderB.ValueChanged и общий Parameter_Changed
            // UpdateSliderLabels();
            // UpdatePlot();
        }
    }
}