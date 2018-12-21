namespace SandboxUI.Forms
{
    partial class NewNetworkDialog
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
            this.pnlHeaders = new System.Windows.Forms.Panel();
            this.lblLearningRate = new System.Windows.Forms.Label();
            this.lblNodeCount = new System.Windows.Forms.Label();
            this.lblActivationMethod = new System.Windows.Forms.Label();
            this.lblLayerNumber = new System.Windows.Forms.Label();
            this.flpAddLayerControls = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateNetwork = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlHeaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(537, 3);
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlWindowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindowBar.Size = new System.Drawing.Size(592, 51);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnClear);
            this.pnlContent.Controls.Add(this.btnLoadConfig);
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.btnCreateNetwork);
            this.pnlContent.Controls.Add(this.flpAddLayerControls);
            this.pnlContent.Controls.Add(this.pnlHeaders);
            this.pnlContent.Location = new System.Drawing.Point(15, 54);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(562, 401);
            // 
            // pnlHeaders
            // 
            this.pnlHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaders.Controls.Add(this.lblLearningRate);
            this.pnlHeaders.Controls.Add(this.lblNodeCount);
            this.pnlHeaders.Controls.Add(this.lblActivationMethod);
            this.pnlHeaders.Controls.Add(this.lblLayerNumber);
            this.pnlHeaders.Location = new System.Drawing.Point(9, 3);
            this.pnlHeaders.Name = "pnlHeaders";
            this.pnlHeaders.Size = new System.Drawing.Size(540, 33);
            this.pnlHeaders.TabIndex = 1;
            // 
            // lblLearningRate
            // 
            this.lblLearningRate.AutoSize = true;
            this.lblLearningRate.ForeColor = System.Drawing.Color.White;
            this.lblLearningRate.Location = new System.Drawing.Point(292, 3);
            this.lblLearningRate.Name = "lblLearningRate";
            this.lblLearningRate.Size = new System.Drawing.Size(115, 23);
            this.lblLearningRate.TabIndex = 4;
            this.lblLearningRate.Text = "Learning Rate";
            // 
            // lblNodeCount
            // 
            this.lblNodeCount.AutoSize = true;
            this.lblNodeCount.ForeColor = System.Drawing.Color.White;
            this.lblNodeCount.Location = new System.Drawing.Point(413, 3);
            this.lblNodeCount.Name = "lblNodeCount";
            this.lblNodeCount.Size = new System.Drawing.Size(104, 23);
            this.lblNodeCount.TabIndex = 3;
            this.lblNodeCount.Text = "Node Count";
            // 
            // lblActivationMethod
            // 
            this.lblActivationMethod.AutoSize = true;
            this.lblActivationMethod.ForeColor = System.Drawing.Color.White;
            this.lblActivationMethod.Location = new System.Drawing.Point(135, 3);
            this.lblActivationMethod.Name = "lblActivationMethod";
            this.lblActivationMethod.Size = new System.Drawing.Size(151, 23);
            this.lblActivationMethod.TabIndex = 2;
            this.lblActivationMethod.Text = "Activation Method";
            // 
            // lblLayerNumber
            // 
            this.lblLayerNumber.AutoSize = true;
            this.lblLayerNumber.ForeColor = System.Drawing.Color.White;
            this.lblLayerNumber.Location = new System.Drawing.Point(12, 3);
            this.lblLayerNumber.Name = "lblLayerNumber";
            this.lblLayerNumber.Size = new System.Drawing.Size(118, 23);
            this.lblLayerNumber.TabIndex = 1;
            this.lblLayerNumber.Text = "Layer Number";
            // 
            // flpAddLayerControls
            // 
            this.flpAddLayerControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpAddLayerControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAddLayerControls.Location = new System.Drawing.Point(9, 42);
            this.flpAddLayerControls.Name = "flpAddLayerControls";
            this.flpAddLayerControls.Size = new System.Drawing.Size(540, 306);
            this.flpAddLayerControls.TabIndex = 2;
            // 
            // btnCreateNetwork
            // 
            this.btnCreateNetwork.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCreateNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNetwork.Location = new System.Drawing.Point(394, 355);
            this.btnCreateNetwork.Name = "btnCreateNetwork";
            this.btnCreateNetwork.Size = new System.Drawing.Size(155, 38);
            this.btnCreateNetwork.TabIndex = 3;
            this.btnCreateNetwork.Text = "Create Network";
            this.btnCreateNetwork.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(9, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLoadConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadConfig.Location = new System.Drawing.Point(213, 354);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(175, 38);
            this.btnLoadConfig.TabIndex = 5;
            this.btnLoadConfig.Text = "Load Configuration";
            this.btnLoadConfig.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Olive;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(104, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // NewNetworkDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 466);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "NewNetworkDialog";
            this.Text = "NewNetworkDialog";
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlHeaders.ResumeLayout(false);
            this.pnlHeaders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaders;
        private System.Windows.Forms.Label lblNodeCount;
        private System.Windows.Forms.Label lblActivationMethod;
        private System.Windows.Forms.Label lblLayerNumber;
        private System.Windows.Forms.FlowLayoutPanel flpAddLayerControls;
        private System.Windows.Forms.Label lblLearningRate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateNetwork;
    }
}