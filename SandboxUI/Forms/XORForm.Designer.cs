namespace SandboxUI.Forms
{
    partial class XORForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtCostFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlNetworkConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCostFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(1012, 0);
            this.btnCloseWindow.Size = new System.Drawing.Size(55, 35);
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimizeWindow.Location = new System.Drawing.Point(902, 0);
            this.btnMinimizeWindow.Size = new System.Drawing.Size(55, 35);
            // 
            // btnMaximizeWindow
            // 
            this.btnMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMaximizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMaximizeWindow.Location = new System.Drawing.Point(957, 0);
            this.btnMaximizeWindow.Size = new System.Drawing.Size(55, 35);
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Size = new System.Drawing.Size(1067, 35);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.chtCostFunction);
            this.pnlContent.Size = new System.Drawing.Size(1042, 697);
            this.pnlContent.Controls.SetChildIndex(this.chtCostFunction, 0);
            this.pnlContent.Controls.SetChildIndex(this.pnlNetworkConfiguration, 0);
            // 
            // btnClearNetwork
            // 
            this.btnClearNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // btnEditNetwork
            // 
            this.btnEditNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(125)))));
            // 
            // btnNewNetwork
            // 
            this.btnNewNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(125)))), ((int)(((byte)(64)))));
            // 
            // chtCostFunction
            // 
            this.chtCostFunction.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.chtCostFunction.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chtCostFunction.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.SystemColors.WindowFrame;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Black;
            this.chtCostFunction.ChartAreas.Add(chartArea1);
            this.chtCostFunction.Location = new System.Drawing.Point(293, 6);
            this.chtCostFunction.Name = "chtCostFunction";
            this.chtCostFunction.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            this.chtCostFunction.Series.Add(series1);
            this.chtCostFunction.Size = new System.Drawing.Size(749, 261);
            this.chtCostFunction.TabIndex = 2;
            this.chtCostFunction.Text = "chart1";
            // 
            // XORForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 756);
            this.Name = "XORForm";
            this.Text = "XOR Simulation";
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlNetworkConfiguration.ResumeLayout(false);
            this.pnlNetworkConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCostFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCostFunction;
    }
}