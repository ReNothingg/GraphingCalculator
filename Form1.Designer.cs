namespace Mathway
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.sliderA = new System.Windows.Forms.TrackBar();
            this.sliderB = new System.Windows.Forms.TrackBar();
            this.cofALabel = new System.Windows.Forms.Label();
            this.cofBLabel = new System.Windows.Forms.Label();
            this.xMinNumeric = new System.Windows.Forms.NumericUpDown();
            this.xMaxNumeric = new System.Windows.Forms.NumericUpDown();
            this.xStepNumeric = new System.Windows.Forms.NumericUpDown();
            this.plotButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelXmin = new System.Windows.Forms.Label();
            this.labelXmax = new System.Windows.Forms.Label();
            this.labelXstep = new System.Windows.Forms.Label();
            this.labelSliderA = new System.Windows.Forms.Label();
            this.labelSliderB = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sliderA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMinNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xStepNumeric)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(15, 28);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(248, 23);
            this.inputTextBox.TabIndex = 0;
            // 
            // plotView
            // 
            this.plotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotView.Location = new System.Drawing.Point(283, 3);
            this.plotView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView.Size = new System.Drawing.Size(648, 555);
            this.plotView.TabIndex = 1;
            this.plotView.Text = "plotView1";
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // sliderA
            // 
            this.sliderA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderA.Location = new System.Drawing.Point(15, 290);
            this.sliderA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sliderA.Minimum = -10;
            this.sliderA.Name = "sliderA";
            this.sliderA.Size = new System.Drawing.Size(248, 45);
            this.sliderA.TabIndex = 4;
            this.sliderA.TickFrequency = 1;
            // 
            // sliderB
            // 
            this.sliderB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderB.Location = new System.Drawing.Point(15, 370);
            this.sliderB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sliderB.Minimum = -10;
            this.sliderB.Name = "sliderB";
            this.sliderB.Size = new System.Drawing.Size(248, 45);
            this.sliderB.TabIndex = 6;
            this.sliderB.TickFrequency = 1;
            // 
            // cofALabel
            // 
            this.cofALabel.AutoSize = true;
            this.cofALabel.Location = new System.Drawing.Point(15, 325); // Adjusted position
            this.cofALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cofALabel.Name = "cofALabel";
            this.cofALabel.Size = new System.Drawing.Size(29, 15);
            this.cofALabel.TabIndex = 5;
            this.cofALabel.Text = "a: 0";
            // 
            // cofBLabel
            // 
            this.cofBLabel.AutoSize = true;
            this.cofBLabel.Location = new System.Drawing.Point(15, 405); // Adjusted position
            this.cofBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cofBLabel.Name = "cofBLabel";
            this.cofBLabel.Size = new System.Drawing.Size(30, 15);
            this.cofBLabel.TabIndex = 7;
            this.cofBLabel.Text = "b: 0";
            // 
            // xMinNumeric
            // 
            this.xMinNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xMinNumeric.DecimalPlaces = 2;
            this.xMinNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.xMinNumeric.Location = new System.Drawing.Point(15, 80);
            this.xMinNumeric.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xMinNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xMinNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.xMinNumeric.Name = "xMinNumeric";
            this.xMinNumeric.Size = new System.Drawing.Size(248, 23);
            this.xMinNumeric.TabIndex = 1;
            // 
            // xMaxNumeric
            // 
            this.xMaxNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xMaxNumeric.DecimalPlaces = 2;
            this.xMaxNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.xMaxNumeric.Location = new System.Drawing.Point(15, 132);
            this.xMaxNumeric.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xMaxNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xMaxNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.xMaxNumeric.Name = "xMaxNumeric";
            this.xMaxNumeric.Size = new System.Drawing.Size(248, 23);
            this.xMaxNumeric.TabIndex = 2;
            // 
            // xStepNumeric
            // 
            this.xStepNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xStepNumeric.DecimalPlaces = 3;
            this.xStepNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.xStepNumeric.Location = new System.Drawing.Point(15, 184);
            this.xStepNumeric.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xStepNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xStepNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.xStepNumeric.Name = "xStepNumeric";
            this.xStepNumeric.Size = new System.Drawing.Size(248, 23);
            this.xStepNumeric.TabIndex = 3;
            this.xStepNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // plotButton
            // 
            this.plotButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotButton.Location = new System.Drawing.Point(15, 440);
            this.plotButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(248, 27);
            this.plotButton.TabIndex = 8;
            this.plotButton.Text = "Построить / Обновить";
            this.plotButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(15, 473);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(248, 27);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(15, 10);
            this.labelInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(91, 15);
            this.labelInput.TabIndex = 10;
            this.labelInput.Text = "Функция (y=...):";
            // 
            // labelXmin
            // 
            this.labelXmin.AutoSize = true;
            this.labelXmin.Location = new System.Drawing.Point(15, 62);
            this.labelXmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXmin.Name = "labelXmin";
            this.labelXmin.Size = new System.Drawing.Size(40, 15);
            this.labelXmin.TabIndex = 11;
            this.labelXmin.Text = "X min:";
            // 
            // labelXmax
            // 
            this.labelXmax.AutoSize = true;
            this.labelXmax.Location = new System.Drawing.Point(15, 114);
            this.labelXmax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXmax.Name = "labelXmax";
            this.labelXmax.Size = new System.Drawing.Size(42, 15);
            this.labelXmax.TabIndex = 12;
            this.labelXmax.Text = "X max:";
            // 
            // labelXstep
            // 
            this.labelXstep.AutoSize = true;
            this.labelXstep.Location = new System.Drawing.Point(15, 166);
            this.labelXstep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXstep.Name = "labelXstep";
            this.labelXstep.Size = new System.Drawing.Size(43, 15);
            this.labelXstep.TabIndex = 13;
            this.labelXstep.Text = "Шаг X:";
            // 
            // labelSliderA
            // 
            this.labelSliderA.AutoSize = true;
            this.labelSliderA.Location = new System.Drawing.Point(15, 272);
            this.labelSliderA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSliderA.Name = "labelSliderA";
            this.labelSliderA.Size = new System.Drawing.Size(90, 15);
            this.labelSliderA.TabIndex = 14;
            this.labelSliderA.Text = "Коэффициент a:";
            // 
            // labelSliderB
            // 
            this.labelSliderB.AutoSize = true;
            this.labelSliderB.Location = new System.Drawing.Point(15, 352);
            this.labelSliderB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSliderB.Name = "labelSliderB";
            this.labelSliderB.Size = new System.Drawing.Size(91, 15);
            this.labelSliderB.TabIndex = 15;
            this.labelSliderB.Text = "Коэффициент b:";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.plotView, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.controlsPanel, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(935, 561);
            this.mainTableLayoutPanel.TabIndex = 16;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.labelInput);
            this.controlsPanel.Controls.Add(this.labelSliderB);
            this.controlsPanel.Controls.Add(this.inputTextBox);
            this.controlsPanel.Controls.Add(this.labelSliderA);
            this.controlsPanel.Controls.Add(this.sliderA);
            this.controlsPanel.Controls.Add(this.labelXstep);
            this.controlsPanel.Controls.Add(this.cofALabel);
            this.controlsPanel.Controls.Add(this.labelXmax);
            this.controlsPanel.Controls.Add(this.sliderB);
            this.controlsPanel.Controls.Add(this.labelXmin);
            this.controlsPanel.Controls.Add(this.cofBLabel);
            this.controlsPanel.Controls.Add(this.xMinNumeric);
            this.controlsPanel.Controls.Add(this.resetButton);
            this.controlsPanel.Controls.Add(this.xMaxNumeric);
            this.controlsPanel.Controls.Add(this.plotButton);
            this.controlsPanel.Controls.Add(this.xStepNumeric);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(3, 3);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.controlsPanel.Size = new System.Drawing.Size(274, 555);
            this.controlsPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 561);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.Text = "Графический калькулятор Mathway";
            ((System.ComponentModel.ISupportInitialize)(this.sliderA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMinNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xStepNumeric)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private OxyPlot.WindowsForms.PlotView plotView;
        private System.Windows.Forms.TrackBar sliderA;
        private System.Windows.Forms.TrackBar sliderB;
        private System.Windows.Forms.Label cofALabel;
        private System.Windows.Forms.Label cofBLabel;
        private System.Windows.Forms.NumericUpDown xMinNumeric;
        private System.Windows.Forms.NumericUpDown xMaxNumeric;
        private System.Windows.Forms.NumericUpDown xStepNumeric;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelXmin;
        private System.Windows.Forms.Label labelXmax;
        private System.Windows.Forms.Label labelXstep;
        private System.Windows.Forms.Label labelSliderA;
        private System.Windows.Forms.Label labelSliderB;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel controlsPanel;
    }
}