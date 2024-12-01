using System;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Globalization;

namespace Mathway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlotButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input = inputTextBox.Text.ToLower().Replace(" ", "");

                if (!input.Contains("x"))
                {
                    MessageBox.Show("Функция должна содержать переменную x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!input.StartsWith("y="))
                {
                    MessageBox.Show("Функция должна начинаться с 'y='.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                input = input.Substring(2);

                var model = new PlotModel { Title = "График функции" };
                var series = new LineSeries { Color = OxyColors.Blue };

                double a = (double)sliderA.Value;
                double b = (double)sliderB.Value;


                for (double x = -10; x <= 10; x += 0.1)
                {
                    double y = EvaluateFunction(input, x, a, b);
                    if (double.IsNaN(y) || double.IsInfinity(y))
                        continue;
                    series.Points.Add(new DataPoint(x, y));
                }

                model.Series.Add(series);
                plotView.Model = model;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка построения графика: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double EvaluateFunction(string expression, double x, double a, double b)
        {
            try
            {
                expression = expression.Replace("sin", "Math.Sin")
                                       .Replace("cos", "Math.Cos")
                                       .Replace("tan", "Math.Tan")
                                       .Replace("exp", "Math.Exp")
                                       .Replace("log", "Math.Log")
                                       .Replace("sqrt", "Math.Sqrt");

                expression = expression.Replace("x", x.ToString(CultureInfo.InvariantCulture))
                                       .Replace("a", a.ToString(CultureInfo.InvariantCulture))
                                       .Replace("b", b.ToString(CultureInfo.InvariantCulture));

                return ExecuteManualEvaluation(expression);
            }
            catch
            {
                throw new Exception("Некорректное выражение. Проверьте ввод.");
            }
        }

        private double ExecuteManualEvaluation(string expression)
        {
            try
            {
                var table = new System.Data.DataTable();
                table.Locale = CultureInfo.InvariantCulture;
                var result = table.Compute(expression, null);
                return Convert.ToDouble(result);
            }
            catch
            {
                throw new Exception("Некорректное выражение. Проверьте ввод.");
            }
        }

        private void sliderA_Scroll(object sender, ScrollEventArgs e) => cofA.Text = Convert.ToString((double)sliderA.Value);

        private void sliderB_Scroll(object sender, ScrollEventArgs e) => cofB.Text = Convert.ToString((double)sliderB.Value);
    }
}
