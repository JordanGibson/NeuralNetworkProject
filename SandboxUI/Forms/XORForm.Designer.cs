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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlNetworkConfiguration = new System.Windows.Forms.Panel();
            this.btnClearNetwork = new System.Windows.Forms.Button();
            this.btnEditNetwork = new System.Windows.Forms.Button();
            this.btnNewNetwork = new System.Windows.Forms.Button();
            this.lblCurrentError = new System.Windows.Forms.Label();
            this.lblActivationMethod = new System.Windows.Forms.Label();
            this.lblLearningRate = new System.Windows.Forms.Label();
            this.lblNetworkStructure = new System.Windows.Forms.Label();
            this.lblNetworkConfig = new System.Windows.Forms.Label();
            this.chtCostFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlWindowBar.SuspendLayout();
            this.pnlNetworkConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCostFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(1145, 0);
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimizeWindow.Location = new System.Drawing.Point(1035, 0);
            // 
            // btnMaximizeWindow
            // 
            this.btnMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMaximizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMaximizeWindow.Location = new System.Drawing.Point(1090, 0);
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Size = new System.Drawing.Size(1200, 40);
            // 
            // pnlNetworkConfiguration
            // 
            this.pnlNetworkConfiguration.Controls.Add(this.btnClearNetwork);
            this.pnlNetworkConfiguration.Controls.Add(this.btnEditNetwork);
            this.pnlNetworkConfiguration.Controls.Add(this.btnNewNetwork);
            this.pnlNetworkConfiguration.Controls.Add(this.lblCurrentError);
            this.pnlNetworkConfiguration.Controls.Add(this.lblActivationMethod);
            this.pnlNetworkConfiguration.Controls.Add(this.lblLearningRate);
            this.pnlNetworkConfiguration.Controls.Add(this.lblNetworkStructure);
            this.pnlNetworkConfiguration.Controls.Add(this.lblNetworkConfig);
            this.pnlNetworkConfiguration.Location = new System.Drawing.Point(13, 47);
            this.pnlNetworkConfiguration.Name = "pnlNetworkConfiguration";
            this.pnlNetworkConfiguration.Size = new System.Drawing.Size(326, 300);
            this.pnlNetworkConfiguration.TabIndex = 1;
            // 
            // btnClearNetwork
            // 
            this.btnClearNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNetwork.Location = new System.Drawing.Point(8, 245);
            this.btnClearNetwork.Name = "btnClearNetwork";
            this.btnClearNetwork.Size = new System.Drawing.Size(306, 42);
            this.btnClearNetwork.TabIndex = 7;
            this.btnClearNetwork.Text = "Clear Network";
            this.btnClearNetwork.UseVisualStyleBackColor = true;
            // 
            // btnEditNetwork
            // 
            this.btnEditNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(125)))));
            this.btnEditNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNetwork.Location = new System.Drawing.Point(8, 197);
            this.btnEditNetwork.Name = "btnEditNetwork";
            this.btnEditNetwork.Size = new System.Drawing.Size(306, 42);
            this.btnEditNetwork.TabIndex = 6;
            this.btnEditNetwork.Text = "Edit Network";
            this.btnEditNetwork.UseVisualStyleBackColor = true;
            // 
            // btnNewNetwork
            // 
            this.btnNewNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(125)))), ((int)(((byte)(64)))));
            this.btnNewNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewNetwork.Location = new System.Drawing.Point(8, 149);
            this.btnNewNetwork.Name = "btnNewNetwork";
            this.btnNewNetwork.Size = new System.Drawing.Size(306, 42);
            this.btnNewNetwork.TabIndex = 5;
            this.btnNewNetwork.Text = "New Network";
            this.btnNewNetwork.UseVisualStyleBackColor = true;
            this.btnNewNetwork.Click += new System.EventHandler(this.btnNewNetwork_Click);
            // 
            // lblCurrentError
            // 
            this.lblCurrentError.AutoSize = true;
            this.lblCurrentError.Location = new System.Drawing.Point(8, 115);
            this.lblCurrentError.Name = "lblCurrentError";
            this.lblCurrentError.Size = new System.Drawing.Size(150, 23);
            this.lblCurrentError.TabIndex = 4;
            this.lblCurrentError.Text = "Current Error: N/A";
            // 
            // lblActivationMethod
            // 
            this.lblActivationMethod.AutoSize = true;
            this.lblActivationMethod.Location = new System.Drawing.Point(8, 87);
            this.lblActivationMethod.Name = "lblActivationMethod";
            this.lblActivationMethod.Size = new System.Drawing.Size(313, 23);
            this.lblActivationMethod.TabIndex = 3;
            this.lblActivationMethod.Text = "Activation Method: No Network Loaded";
            // 
            // lblLearningRate
            // 
            this.lblLearningRate.AutoSize = true;
            this.lblLearningRate.Location = new System.Drawing.Point(8, 59);
            this.lblLearningRate.Name = "lblLearningRate";
            this.lblLearningRate.Size = new System.Drawing.Size(155, 23);
            this.lblLearningRate.TabIndex = 2;
            this.lblLearningRate.Text = "Learning Rate: N/A";
            // 
            // lblNetworkStructure
            // 
            this.lblNetworkStructure.AutoSize = true;
            this.lblNetworkStructure.Location = new System.Drawing.Point(8, 31);
            this.lblNetworkStructure.Name = "lblNetworkStructure";
            this.lblNetworkStructure.Size = new System.Drawing.Size(119, 23);
            this.lblNetworkStructure.TabIndex = 1;
            this.lblNetworkStructure.Text = "Structure: N/A";
            // 
            // lblNetworkConfig
            // 
            this.lblNetworkConfig.AutoSize = true;
            this.lblNetworkConfig.Location = new System.Drawing.Point(4, 4);
            this.lblNetworkConfig.Name = "lblNetworkConfig";
            this.lblNetworkConfig.Size = new System.Drawing.Size(184, 23);
            this.lblNetworkConfig.TabIndex = 0;
            this.lblNetworkConfig.Text = "Network Configuration";
            // 
            // chtCostFunction
            // 
            this.chtCostFunction.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.chtCostFunction.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chtCostFunction.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.SystemColors.WindowFrame;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Black;
            this.chtCostFunction.ChartAreas.Add(chartArea2);
            this.chtCostFunction.Location = new System.Drawing.Point(345, 47);
            this.chtCostFunction.Name = "chtCostFunction";
            this.chtCostFunction.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderColor = System.Drawing.Color.White;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Name = "Series1";
            this.chtCostFunction.Series.Add(series2);
            this.chtCostFunction.Size = new System.Drawing.Size(843, 300);
            this.chtCostFunction.TabIndex = 2;
            this.chtCostFunction.Text = "chart1";
            // 
            // XORForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 869);
            this.Controls.Add(this.chtCostFunction);
            this.Controls.Add(this.pnlNetworkConfiguration);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "XORForm";
            this.Text = "XOR Simulation";
            this.Controls.SetChildIndex(this.pnlWindowBar, 0);
            this.Controls.SetChildIndex(this.pnlNetworkConfiguration, 0);
            this.Controls.SetChildIndex(this.chtCostFunction, 0);
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlNetworkConfiguration.ResumeLayout(false);
            this.pnlNetworkConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCostFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNetworkConfiguration;
        private System.Windows.Forms.Label lblCurrentError;
        private System.Windows.Forms.Label lblActivationMethod;
        private System.Windows.Forms.Label lblLearningRate;
        private System.Windows.Forms.Label lblNetworkStructure;
        private System.Windows.Forms.Label lblNetworkConfig;
        private System.Windows.Forms.Button btnNewNetwork;
        private System.Windows.Forms.Button btnClearNetwork;
        private System.Windows.Forms.Button btnEditNetwork;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCostFunction;
    }
}