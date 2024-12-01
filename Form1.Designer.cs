namespace Mathway
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.plotButton = new System.Windows.Forms.Button();
            this.sliderALabel = new System.Windows.Forms.Label();
            this.sliderBLabel = new System.Windows.Forms.Label();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.sliderA = new System.Windows.Forms.HScrollBar();
            this.sliderB = new System.Windows.Forms.HScrollBar();
            this.cofA = new System.Windows.Forms.Label();
            this.cofB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(10, 26);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(360, 51);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "y=2x";
            // 
            // plotButton
            // 
            this.plotButton.BackColor = System.Drawing.Color.IndianRed;
            this.plotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plotButton.Location = new System.Drawing.Point(10, 470);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(360, 47);
            this.plotButton.TabIndex = 2;
            this.plotButton.Text = "Построить график";
            this.plotButton.UseVisualStyleBackColor = false;
            this.plotButton.Click += new System.EventHandler(this.PlotButton_Click);
            // 
            // sliderALabel
            // 
            this.sliderALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sliderALabel.Location = new System.Drawing.Point(10, 366);
            this.sliderALabel.Name = "sliderALabel";
            this.sliderALabel.Size = new System.Drawing.Size(100, 33);
            this.sliderALabel.TabIndex = 3;
            this.sliderALabel.Text = "Коэффициент A:";
            // 
            // sliderBLabel
            // 
            this.sliderBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sliderBLabel.Location = new System.Drawing.Point(10, 438);
            this.sliderBLabel.Name = "sliderBLabel";
            this.sliderBLabel.Size = new System.Drawing.Size(100, 29);
            this.sliderBLabel.TabIndex = 5;
            this.sliderBLabel.Text = "Коэффициент B:";
            // 
            // plotView
            // 
            this.plotView.BackColor = System.Drawing.Color.Silver;
            this.plotView.Location = new System.Drawing.Point(376, 10);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView.Size = new System.Drawing.Size(622, 507);
            this.plotView.TabIndex = 7;
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // sliderA
            // 
            this.sliderA.Location = new System.Drawing.Point(113, 366);
            this.sliderA.Name = "sliderA";
            this.sliderA.Size = new System.Drawing.Size(218, 33);
            this.sliderA.TabIndex = 8;
            this.sliderA.Value = 1;
            this.sliderA.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sliderA_Scroll);
            // 
            // sliderB
            // 
            this.sliderB.Location = new System.Drawing.Point(113, 438);
            this.sliderB.Name = "sliderB";
            this.sliderB.Size = new System.Drawing.Size(218, 29);
            this.sliderB.TabIndex = 9;
            this.sliderB.Value = 1;
            this.sliderB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sliderB_Scroll);
            // 
            // cofA
            // 
            this.cofA.AutoSize = true;
            this.cofA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cofA.Location = new System.Drawing.Point(334, 366);
            this.cofA.Name = "cofA";
            this.cofA.Size = new System.Drawing.Size(23, 25);
            this.cofA.TabIndex = 10;
            this.cofA.Text = "1";
            // 
            // cofB
            // 
            this.cofB.AutoSize = true;
            this.cofB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cofB.Location = new System.Drawing.Point(334, 442);
            this.cofB.Name = "cofB";
            this.cofB.Size = new System.Drawing.Size(23, 25);
            this.cofB.TabIndex = 11;
            this.cofB.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1010, 524);
            this.Controls.Add(this.cofB);
            this.Controls.Add(this.cofA);
            this.Controls.Add(this.sliderB);
            this.Controls.Add(this.sliderA);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.sliderALabel);
            this.Controls.Add(this.sliderBLabel);
            this.Controls.Add(this.plotView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Mathway - Построение графиков";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Label sliderALabel;
        private System.Windows.Forms.Label sliderBLabel;
        private OxyPlot.WindowsForms.PlotView plotView;
        private System.Windows.Forms.HScrollBar sliderA;
        private System.Windows.Forms.HScrollBar sliderB;
        private System.Windows.Forms.Label cofA;
        private System.Windows.Forms.Label cofB;
    }
}
