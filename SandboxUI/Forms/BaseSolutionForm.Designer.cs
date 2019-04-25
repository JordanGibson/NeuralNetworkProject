using System.Drawing;
using System.Windows.Forms;

namespace SandboxUI.Forms
{
    partial class BaseSolutionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseSolutionForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlWindowBar = new System.Windows.Forms.Panel();
            this.lblWindowTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnMaximizeWindow = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.bdcWindowDragger = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ellipseStyler = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bdcLabelDragger = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.chtScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTrainingStatus = new System.Windows.Forms.Panel();
            this.btnCancelTraining = new System.Windows.Forms.Button();
            this.lblTrainingStatus = new System.Windows.Forms.Label();
            this.pgbTrainingProgress = new System.Windows.Forms.ProgressBar();
            this.pnlNetworkTraining = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.nudTrainX = new System.Windows.Forms.NumericUpDown();
            this.btnTrainX = new System.Windows.Forms.Button();
            this.btnTrain2000 = new System.Windows.Forms.Button();
            this.btnTrain500 = new System.Windows.Forms.Button();
            this.lblLastTrainedCount = new System.Windows.Forms.Label();
            this.lblTrainedCount = new System.Windows.Forms.Label();
            this.lblNetworkState = new System.Windows.Forms.Label();
            this.pbxVisualRepresentation = new System.Windows.Forms.PictureBox();
            this.chtCurrentStateLoss = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlNetworkConfiguration = new System.Windows.Forms.Panel();
            this.btnSaveNetwork = new System.Windows.Forms.Button();
            this.btnLoadNetwork = new System.Windows.Forms.Button();
            this.btnClearNetwork = new System.Windows.Forms.Button();
            this.btnEditNetwork = new System.Windows.Forms.Button();
            this.btnNewNetwork = new System.Windows.Forms.Button();
            this.lblCurrentError = new System.Windows.Forms.Label();
            this.lblActivationMethod = new System.Windows.Forms.Label();
            this.lblLearningRate = new System.Windows.Forms.Label();
            this.lblNetworkStructure = new System.Windows.Forms.Label();
            this.lblNetworkConfig = new System.Windows.Forms.Label();
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtScore)).BeginInit();
            this.pnlTrainingStatus.SuspendLayout();
            this.pnlNetworkTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrainX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisualRepresentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCurrentStateLoss)).BeginInit();
            this.pnlNetworkConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlWindowBar.Controls.Add(this.lblWindowTitle);
            this.pnlWindowBar.Controls.Add(this.btnMinimizeWindow);
            this.pnlWindowBar.Controls.Add(this.btnMaximizeWindow);
            this.pnlWindowBar.Controls.Add(this.btnCloseWindow);
            this.pnlWindowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindowBar.Location = new System.Drawing.Point(0, 0);
            this.pnlWindowBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlWindowBar.Name = "pnlWindowBar";
            this.pnlWindowBar.Size = new System.Drawing.Size(937, 40);
            this.pnlWindowBar.TabIndex = 0;
            this.pnlWindowBar.DoubleClick += new System.EventHandler(this.pnlWindowBar_DoubleClick);
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.AutoSize = true;
            this.lblWindowTitle.ForeColor = System.Drawing.Color.White;
            this.lblWindowTitle.Location = new System.Drawing.Point(11, 11);
            this.lblWindowTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(186, 25);
            this.lblWindowTitle.TabIndex = 3;
            this.lblWindowTitle.Text = "bunifuCustomLabel1";
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinimizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeWindow.Image")));
            this.btnMinimizeWindow.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizeWindow.Location = new System.Drawing.Point(772, 0);
            this.btnMinimizeWindow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMinimizeWindow.Name = "btnMinimizeWindow";
            this.btnMinimizeWindow.Size = new System.Drawing.Size(55, 40);
            this.btnMinimizeWindow.TabIndex = 2;
            this.btnMinimizeWindow.UseVisualStyleBackColor = true;
            this.btnMinimizeWindow.Click += new System.EventHandler(this.btnMinimizeWindow_Click);
            // 
            // btnMaximizeWindow
            // 
            this.btnMaximizeWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMaximizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMaximizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMaximizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizeWindow.Image")));
            this.btnMaximizeWindow.Location = new System.Drawing.Point(827, 0);
            this.btnMaximizeWindow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMaximizeWindow.Name = "btnMaximizeWindow";
            this.btnMaximizeWindow.Size = new System.Drawing.Size(55, 40);
            this.btnMaximizeWindow.TabIndex = 1;
            this.btnMaximizeWindow.UseVisualStyleBackColor = true;
            this.btnMaximizeWindow.Click += new System.EventHandler(this.btnMaximizeWindow_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseWindow.Image")));
            this.btnCloseWindow.Location = new System.Drawing.Point(882, 0);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(55, 40);
            this.btnCloseWindow.TabIndex = 0;
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // bdcWindowDragger
            // 
            this.bdcWindowDragger.Fixed = true;
            this.bdcWindowDragger.Horizontal = true;
            this.bdcWindowDragger.TargetControl = this.pnlWindowBar;
            this.bdcWindowDragger.Vertical = true;
            // 
            // ellipseStyler
            // 
            this.ellipseStyler.ElipseRadius = 10;
            this.ellipseStyler.TargetControl = this;
            // 
            // bdcLabelDragger
            // 
            this.bdcLabelDragger.Fixed = true;
            this.bdcLabelDragger.Horizontal = true;
            this.bdcLabelDragger.TargetControl = this.lblWindowTitle;
            this.bdcLabelDragger.Vertical = true;
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlContent.Controls.Add(this.chtScore);
            this.pnlContent.Controls.Add(this.pnlTrainingStatus);
            this.pnlContent.Controls.Add(this.pnlNetworkTraining);
            this.pnlContent.Controls.Add(this.pbxVisualRepresentation);
            this.pnlContent.Controls.Add(this.chtCurrentStateLoss);
            this.pnlContent.Controls.Add(this.pnlNetworkConfiguration);
            this.pnlContent.Location = new System.Drawing.Point(13, 47);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(912, 563);
            this.pnlContent.TabIndex = 1;
            // 
            // chtScore
            // 
            this.chtScore.BackColor = System.Drawing.SystemColors.WindowFrame;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Title = "Training Iterations";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Title = "Success Rate";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.SystemColors.WindowFrame;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chtScore.ChartAreas.Add(chartArea1);
            this.chtScore.Location = new System.Drawing.Point(595, 3);
            this.chtScore.Name = "chtScore";
            this.chtScore.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Lime;
            series1.Name = "Series1";
            this.chtScore.Series.Add(series1);
            this.chtScore.Size = new System.Drawing.Size(309, 261);
            this.chtScore.TabIndex = 10;
            // 
            // pnlTrainingStatus
            // 
            this.pnlTrainingStatus.Controls.Add(this.btnCancelTraining);
            this.pnlTrainingStatus.Controls.Add(this.lblTrainingStatus);
            this.pnlTrainingStatus.Controls.Add(this.pgbTrainingProgress);
            this.pnlTrainingStatus.Location = new System.Drawing.Point(14, 520);
            this.pnlTrainingStatus.Name = "pnlTrainingStatus";
            this.pnlTrainingStatus.Size = new System.Drawing.Size(893, 40);
            this.pnlTrainingStatus.TabIndex = 9;
            this.pnlTrainingStatus.Visible = false;
            // 
            // btnCancelTraining
            // 
            this.btnCancelTraining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelTraining.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelTraining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTraining.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.33333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTraining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelTraining.Location = new System.Drawing.Point(855, 7);
            this.btnCancelTraining.Name = "btnCancelTraining";
            this.btnCancelTraining.Size = new System.Drawing.Size(35, 26);
            this.btnCancelTraining.TabIndex = 13;
            this.btnCancelTraining.Text = "X";
            this.btnCancelTraining.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelTraining.UseVisualStyleBackColor = true;
            this.btnCancelTraining.Click += new System.EventHandler(this.btnCancelTraining_Click);
            // 
            // lblTrainingStatus
            // 
            this.lblTrainingStatus.AutoSize = true;
            this.lblTrainingStatus.Location = new System.Drawing.Point(3, 8);
            this.lblTrainingStatus.Name = "lblTrainingStatus";
            this.lblTrainingStatus.Size = new System.Drawing.Size(63, 25);
            this.lblTrainingStatus.TabIndex = 12;
            this.lblTrainingStatus.Text = "label1";
            // 
            // pgbTrainingProgress
            // 
            this.pgbTrainingProgress.Location = new System.Drawing.Point(418, 9);
            this.pgbTrainingProgress.Name = "pgbTrainingProgress";
            this.pgbTrainingProgress.Size = new System.Drawing.Size(431, 23);
            this.pgbTrainingProgress.TabIndex = 11;
            // 
            // pnlNetworkTraining
            // 
            this.pnlNetworkTraining.Controls.Add(this.btnGenerateReport);
            this.pnlNetworkTraining.Controls.Add(this.nudTrainX);
            this.pnlNetworkTraining.Controls.Add(this.btnTrainX);
            this.pnlNetworkTraining.Controls.Add(this.btnTrain2000);
            this.pnlNetworkTraining.Controls.Add(this.btnTrain500);
            this.pnlNetworkTraining.Controls.Add(this.lblLastTrainedCount);
            this.pnlNetworkTraining.Controls.Add(this.lblTrainedCount);
            this.pnlNetworkTraining.Controls.Add(this.lblNetworkState);
            this.pnlNetworkTraining.Enabled = false;
            this.pnlNetworkTraining.Location = new System.Drawing.Point(299, 3);
            this.pnlNetworkTraining.Name = "pnlNetworkTraining";
            this.pnlNetworkTraining.Size = new System.Drawing.Size(290, 261);
            this.pnlNetworkTraining.TabIndex = 8;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Location = new System.Drawing.Point(133, 213);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(147, 37);
            this.btnGenerateReport.TabIndex = 9;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // nudTrainX
            // 
            this.nudTrainX.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudTrainX.ForeColor = System.Drawing.Color.White;
            this.nudTrainX.Location = new System.Drawing.Point(8, 177);
            this.nudTrainX.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudTrainX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTrainX.Name = "nudTrainX";
            this.nudTrainX.Size = new System.Drawing.Size(272, 33);
            this.nudTrainX.TabIndex = 8;
            this.nudTrainX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnTrainX
            // 
            this.btnTrainX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrainX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTrainX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTrainX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainX.Location = new System.Drawing.Point(8, 213);
            this.btnTrainX.Name = "btnTrainX";
            this.btnTrainX.Size = new System.Drawing.Size(119, 37);
            this.btnTrainX.TabIndex = 7;
            this.btnTrainX.Text = "Train";
            this.btnTrainX.UseVisualStyleBackColor = true;
            this.btnTrainX.Click += new System.EventHandler(this.btnTrainX_Click);
            // 
            // btnTrain2000
            // 
            this.btnTrain2000.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrain2000.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTrain2000.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(125)))));
            this.btnTrain2000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain2000.Location = new System.Drawing.Point(8, 134);
            this.btnTrain2000.Name = "btnTrain2000";
            this.btnTrain2000.Size = new System.Drawing.Size(272, 37);
            this.btnTrain2000.TabIndex = 6;
            this.btnTrain2000.Text = "Train 2000 Iterations";
            this.btnTrain2000.UseVisualStyleBackColor = true;
            this.btnTrain2000.Click += new System.EventHandler(this.btnTrain2000_Click);
            // 
            // btnTrain500
            // 
            this.btnTrain500.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrain500.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTrain500.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(125)))), ((int)(((byte)(64)))));
            this.btnTrain500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain500.Location = new System.Drawing.Point(8, 91);
            this.btnTrain500.Name = "btnTrain500";
            this.btnTrain500.Size = new System.Drawing.Size(272, 37);
            this.btnTrain500.TabIndex = 5;
            this.btnTrain500.Text = "Train 500 Iterations";
            this.btnTrain500.UseVisualStyleBackColor = true;
            this.btnTrain500.Click += new System.EventHandler(this.btnTrain500_Click);
            // 
            // lblLastTrainedCount
            // 
            this.lblLastTrainedCount.AutoSize = true;
            this.lblLastTrainedCount.Location = new System.Drawing.Point(7, 56);
            this.lblLastTrainedCount.Name = "lblLastTrainedCount";
            this.lblLastTrainedCount.Size = new System.Drawing.Size(177, 25);
            this.lblLastTrainedCount.TabIndex = 3;
            this.lblLastTrainedCount.Text = "Last Trained Count: ";
            // 
            // lblTrainedCount
            // 
            this.lblTrainedCount.AutoSize = true;
            this.lblTrainedCount.Location = new System.Drawing.Point(7, 29);
            this.lblTrainedCount.Name = "lblTrainedCount";
            this.lblTrainedCount.Size = new System.Drawing.Size(172, 25);
            this.lblTrainedCount.TabIndex = 1;
            this.lblTrainedCount.Text = "Trained Count: N/A";
            // 
            // lblNetworkState
            // 
            this.lblNetworkState.AutoSize = true;
            this.lblNetworkState.Location = new System.Drawing.Point(4, 3);
            this.lblNetworkState.Name = "lblNetworkState";
            this.lblNetworkState.Size = new System.Drawing.Size(129, 25);
            this.lblNetworkState.TabIndex = 0;
            this.lblNetworkState.Text = "Network State";
            // 
            // pbxVisualRepresentation
            // 
            this.pbxVisualRepresentation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxVisualRepresentation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxVisualRepresentation.Location = new System.Drawing.Point(3, 270);
            this.pbxVisualRepresentation.Name = "pbxVisualRepresentation";
            this.pbxVisualRepresentation.Size = new System.Drawing.Size(290, 290);
            this.pbxVisualRepresentation.TabIndex = 4;
            this.pbxVisualRepresentation.TabStop = false;
            // 
            // chtCurrentStateLoss
            // 
            this.chtCurrentStateLoss.BackColor = System.Drawing.SystemColors.WindowFrame;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.Title = "Training Iterations";
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.Title = "Loss";
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.SystemColors.WindowFrame;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chtCurrentStateLoss.ChartAreas.Add(chartArea2);
            this.chtCurrentStateLoss.Location = new System.Drawing.Point(273, 270);
            this.chtCurrentStateLoss.Name = "chtCurrentStateLoss";
            this.chtCurrentStateLoss.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Lime;
            series2.Name = "Series1";
            this.chtCurrentStateLoss.Series.Add(series2);
            this.chtCurrentStateLoss.Size = new System.Drawing.Size(658, 293);
            this.chtCurrentStateLoss.TabIndex = 3;
            // 
            // pnlNetworkConfiguration
            // 
            this.pnlNetworkConfiguration.Controls.Add(this.btnSaveNetwork);
            this.pnlNetworkConfiguration.Controls.Add(this.btnLoadNetwork);
            this.pnlNetworkConfiguration.Controls.Add(this.btnClearNetwork);
            this.pnlNetworkConfiguration.Controls.Add(this.btnEditNetwork);
            this.pnlNetworkConfiguration.Controls.Add(this.btnNewNetwork);
            this.pnlNetworkConfiguration.Controls.Add(this.lblCurrentError);
            this.pnlNetworkConfiguration.Controls.Add(this.lblActivationMethod);
            this.pnlNetworkConfiguration.Controls.Add(this.lblLearningRate);
            this.pnlNetworkConfiguration.Controls.Add(this.lblNetworkStructure);
            this.pnlNetworkConfiguration.Controls.Add(this.lblNetworkConfig);
            this.pnlNetworkConfiguration.Location = new System.Drawing.Point(3, 3);
            this.pnlNetworkConfiguration.Name = "pnlNetworkConfiguration";
            this.pnlNetworkConfiguration.Size = new System.Drawing.Size(290, 261);
            this.pnlNetworkConfiguration.TabIndex = 2;
            // 
            // btnSaveNetwork
            // 
            this.btnSaveNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNetwork.Enabled = false;
            this.btnSaveNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(125)))), ((int)(((byte)(64)))));
            this.btnSaveNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNetwork.Location = new System.Drawing.Point(155, 171);
            this.btnSaveNetwork.Name = "btnSaveNetwork";
            this.btnSaveNetwork.Size = new System.Drawing.Size(132, 37);
            this.btnSaveNetwork.TabIndex = 9;
            this.btnSaveNetwork.Text = "Save Network";
            this.btnSaveNetwork.UseVisualStyleBackColor = true;
            this.btnSaveNetwork.Click += new System.EventHandler(this.btnSaveNetwork_Click);
            // 
            // btnLoadNetwork
            // 
            this.btnLoadNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoadNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(125)))), ((int)(((byte)(64)))));
            this.btnLoadNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadNetwork.Location = new System.Drawing.Point(155, 130);
            this.btnLoadNetwork.Name = "btnLoadNetwork";
            this.btnLoadNetwork.Size = new System.Drawing.Size(132, 37);
            this.btnLoadNetwork.TabIndex = 8;
            this.btnLoadNetwork.Text = "Load Network";
            this.btnLoadNetwork.UseVisualStyleBackColor = true;
            this.btnLoadNetwork.Click += new System.EventHandler(this.btnLoadNetwork_Click);
            // 
            // btnClearNetwork
            // 
            this.btnClearNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearNetwork.Enabled = false;
            this.btnClearNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNetwork.Location = new System.Drawing.Point(7, 213);
            this.btnClearNetwork.Name = "btnClearNetwork";
            this.btnClearNetwork.Size = new System.Drawing.Size(280, 37);
            this.btnClearNetwork.TabIndex = 7;
            this.btnClearNetwork.Text = "Clear Network";
            this.btnClearNetwork.UseVisualStyleBackColor = true;
            this.btnClearNetwork.Click += new System.EventHandler(this.btnClearNetwork_Click);
            // 
            // btnEditNetwork
            // 
            this.btnEditNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditNetwork.Enabled = false;
            this.btnEditNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(125)))));
            this.btnEditNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNetwork.Location = new System.Drawing.Point(7, 171);
            this.btnEditNetwork.Name = "btnEditNetwork";
            this.btnEditNetwork.Size = new System.Drawing.Size(143, 37);
            this.btnEditNetwork.TabIndex = 6;
            this.btnEditNetwork.Text = "Edit Network";
            this.btnEditNetwork.UseVisualStyleBackColor = true;
            this.btnEditNetwork.Click += new System.EventHandler(this.btnEditNetwork_Click);
            // 
            // btnNewNetwork
            // 
            this.btnNewNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(125)))), ((int)(((byte)(64)))));
            this.btnNewNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewNetwork.Location = new System.Drawing.Point(7, 130);
            this.btnNewNetwork.Name = "btnNewNetwork";
            this.btnNewNetwork.Size = new System.Drawing.Size(143, 37);
            this.btnNewNetwork.TabIndex = 5;
            this.btnNewNetwork.Text = "New Network";
            this.btnNewNetwork.UseVisualStyleBackColor = true;
            this.btnNewNetwork.Click += new System.EventHandler(this.btnNewNetwork_Click);
            // 
            // lblCurrentError
            // 
            this.lblCurrentError.AutoSize = true;
            this.lblCurrentError.Location = new System.Drawing.Point(7, 100);
            this.lblCurrentError.Name = "lblCurrentError";
            this.lblCurrentError.Size = new System.Drawing.Size(165, 25);
            this.lblCurrentError.TabIndex = 4;
            this.lblCurrentError.Text = "Current Error: N/A";
            // 
            // lblActivationMethod
            // 
            this.lblActivationMethod.AutoSize = true;
            this.lblActivationMethod.Enabled = false;
            this.lblActivationMethod.Location = new System.Drawing.Point(7, 76);
            this.lblActivationMethod.Name = "lblActivationMethod";
            this.lblActivationMethod.Size = new System.Drawing.Size(226, 25);
            this.lblActivationMethod.TabIndex = 3;
            this.lblActivationMethod.Text = "Show Activation Methods";
            this.lblActivationMethod.Click += new System.EventHandler(this.lblActivationMethod_Click);
            this.lblActivationMethod.MouseEnter += new System.EventHandler(this.clickableLabels_MouseEnter);
            this.lblActivationMethod.MouseLeave += new System.EventHandler(this.clickableLabels_MouseLeave);
            // 
            // lblLearningRate
            // 
            this.lblLearningRate.AutoSize = true;
            this.lblLearningRate.Enabled = false;
            this.lblLearningRate.Location = new System.Drawing.Point(7, 51);
            this.lblLearningRate.Name = "lblLearningRate";
            this.lblLearningRate.Size = new System.Drawing.Size(187, 25);
            this.lblLearningRate.TabIndex = 2;
            this.lblLearningRate.Text = "Show Learning Rates";
            this.lblLearningRate.Click += new System.EventHandler(this.lblLearningRate_Click);
            this.lblLearningRate.MouseEnter += new System.EventHandler(this.clickableLabels_MouseEnter);
            this.lblLearningRate.MouseLeave += new System.EventHandler(this.clickableLabels_MouseLeave);
            // 
            // lblNetworkStructure
            // 
            this.lblNetworkStructure.AutoSize = true;
            this.lblNetworkStructure.Location = new System.Drawing.Point(7, 27);
            this.lblNetworkStructure.Name = "lblNetworkStructure";
            this.lblNetworkStructure.Size = new System.Drawing.Size(130, 25);
            this.lblNetworkStructure.TabIndex = 1;
            this.lblNetworkStructure.Text = "Structure: N/A";
            // 
            // lblNetworkConfig
            // 
            this.lblNetworkConfig.AutoSize = true;
            this.lblNetworkConfig.Location = new System.Drawing.Point(4, 3);
            this.lblNetworkConfig.Name = "lblNetworkConfig";
            this.lblNetworkConfig.Size = new System.Drawing.Size(205, 25);
            this.lblNetworkConfig.TabIndex = 0;
            this.lblNetworkConfig.Text = "Network Configuration";
            // 
            // BaseSolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(937, 622);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlWindowBar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BaseSolutionForm";
            this.Text = "BaseWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseSolutionForm_FormClosing);
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtScore)).EndInit();
            this.pnlTrainingStatus.ResumeLayout(false);
            this.pnlTrainingStatus.PerformLayout();
            this.pnlNetworkTraining.ResumeLayout(false);
            this.pnlNetworkTraining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrainX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisualRepresentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCurrentStateLoss)).EndInit();
            this.pnlNetworkConfiguration.ResumeLayout(false);
            this.pnlNetworkConfiguration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnCloseWindow;
        protected System.Windows.Forms.Button btnMinimizeWindow;
        protected System.Windows.Forms.Button btnMaximizeWindow;
        protected System.Windows.Forms.Panel pnlWindowBar;
        protected Bunifu.Framework.UI.BunifuDragControl bdcWindowDragger;
        protected Bunifu.Framework.UI.BunifuCustomLabel lblWindowTitle;
        private Bunifu.Framework.UI.BunifuElipse ellipseStyler;
        private Bunifu.Framework.UI.BunifuDragControl bdcLabelDragger;
        public Panel pnlContent;
        public Panel pnlNetworkConfiguration;
        public Button btnClearNetwork;
        public Button btnEditNetwork;
        public Button btnNewNetwork;
        public Label lblCurrentError;
        public Label lblActivationMethod;
        public Label lblLearningRate;
        public Label lblNetworkStructure;
        public Label lblNetworkConfig;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCurrentStateLoss;
        public PictureBox pbxVisualRepresentation;
        public Button btnSaveNetwork;
        public Button btnLoadNetwork;
        public Button btnCancelTraining;
        public Panel pnlTrainingStatus;
        public Label lblTrainingStatus;
        public ProgressBar pgbTrainingProgress;
        public Panel pnlNetworkTraining;
        public Button btnGenerateReport;
        private NumericUpDown nudTrainX;
        public Button btnTrainX;
        public Button btnTrain2000;
        public Button btnTrain500;
        public Label lblLastTrainedCount;
        public Label lblTrainedCount;
        public Label lblNetworkState;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtScore;
    }
}