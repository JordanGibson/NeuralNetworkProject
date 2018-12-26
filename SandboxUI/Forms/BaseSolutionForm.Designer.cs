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
            this.pnlWindowBar = new System.Windows.Forms.Panel();
            this.lblWindowTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnMaximizeWindow = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.bdcWindowDragger = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ellipseStyler = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bdcLabelDragger = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlNetworkConfiguration = new System.Windows.Forms.Panel();
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
            this.pnlWindowBar.Size = new System.Drawing.Size(843, 40);
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
            this.lblWindowTitle.Size = new System.Drawing.Size(155, 21);
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
            this.btnMinimizeWindow.Location = new System.Drawing.Point(678, 0);
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
            this.btnMaximizeWindow.Location = new System.Drawing.Point(733, 0);
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
            this.btnCloseWindow.Location = new System.Drawing.Point(788, 0);
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
            this.pnlContent.Controls.Add(this.pnlNetworkConfiguration);
            this.pnlContent.Location = new System.Drawing.Point(13, 47);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(818, 390);
            this.pnlContent.TabIndex = 1;
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
            this.pnlNetworkConfiguration.Location = new System.Drawing.Point(3, 3);
            this.pnlNetworkConfiguration.Name = "pnlNetworkConfiguration";
            this.pnlNetworkConfiguration.Size = new System.Drawing.Size(290, 261);
            this.pnlNetworkConfiguration.TabIndex = 2;
            // 
            // btnClearNetwork
            // 
            this.btnClearNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNetwork.Location = new System.Drawing.Point(7, 213);
            this.btnClearNetwork.Name = "btnClearNetwork";
            this.btnClearNetwork.Size = new System.Drawing.Size(272, 37);
            this.btnClearNetwork.TabIndex = 7;
            this.btnClearNetwork.Text = "Clear Network";
            this.btnClearNetwork.UseVisualStyleBackColor = true;
            this.btnClearNetwork.Click += new System.EventHandler(this.btnClearNetwork_Click);
            // 
            // btnEditNetwork
            // 
            this.btnEditNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(125)))));
            this.btnEditNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNetwork.Location = new System.Drawing.Point(7, 171);
            this.btnEditNetwork.Name = "btnEditNetwork";
            this.btnEditNetwork.Size = new System.Drawing.Size(272, 37);
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
            this.btnNewNetwork.Size = new System.Drawing.Size(272, 37);
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
            this.lblCurrentError.Size = new System.Drawing.Size(137, 21);
            this.lblCurrentError.TabIndex = 4;
            this.lblCurrentError.Text = "Current Error: N/A";
            // 
            // lblActivationMethod
            // 
            this.lblActivationMethod.AutoSize = true;
            this.lblActivationMethod.Enabled = false;
            this.lblActivationMethod.Location = new System.Drawing.Point(7, 76);
            this.lblActivationMethod.Name = "lblActivationMethod";
            this.lblActivationMethod.Size = new System.Drawing.Size(187, 21);
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
            this.lblLearningRate.Size = new System.Drawing.Size(156, 21);
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
            this.lblNetworkStructure.Size = new System.Drawing.Size(108, 21);
            this.lblNetworkStructure.TabIndex = 1;
            this.lblNetworkStructure.Text = "Structure: N/A";
            // 
            // lblNetworkConfig
            // 
            this.lblNetworkConfig.AutoSize = true;
            this.lblNetworkConfig.Location = new System.Drawing.Point(4, 3);
            this.lblNetworkConfig.Name = "lblNetworkConfig";
            this.lblNetworkConfig.Size = new System.Drawing.Size(170, 21);
            this.lblNetworkConfig.TabIndex = 0;
            this.lblNetworkConfig.Text = "Network Configuration";
            // 
            // BaseSolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(843, 449);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlWindowBar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BaseSolutionForm";
            this.Text = "BaseWindow";
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
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
    }
}