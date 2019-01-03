namespace SandboxUI.Forms
{
    partial class EditNetworkDialog
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
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(91, 308);
            this.btnClear.Size = new System.Drawing.Size(69, 33);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLoadConfig.Location = new System.Drawing.Point(164, 308);
            this.btnLoadConfig.Size = new System.Drawing.Size(100, 33);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateNetwork
            // 
            this.btnCreateNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCreateNetwork.Location = new System.Drawing.Point(372, 308);
            this.btnCreateNetwork.Text = "Set Network";
            // 
            // lblNodeCount
            // 
            this.lblNodeCount.Location = new System.Drawing.Point(386, 12);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(-6114, 3);
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Size = new System.Drawing.Size(533, 45);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnSaveConfig);
            this.pnlContent.Size = new System.Drawing.Size(522, 348);
            this.pnlContent.Controls.SetChildIndex(this.btnCreateNetwork, 0);
            this.pnlContent.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlContent.Controls.SetChildIndex(this.btnLoadConfig, 0);
            this.pnlContent.Controls.SetChildIndex(this.btnClear, 0);
            this.pnlContent.Controls.SetChildIndex(this.lblLayerNumber, 0);
            this.pnlContent.Controls.SetChildIndex(this.lblActivationMethod, 0);
            this.pnlContent.Controls.SetChildIndex(this.lblLearningRate, 0);
            this.pnlContent.Controls.SetChildIndex(this.lblNodeCount, 0);
            this.pnlContent.Controls.SetChildIndex(this.btnSaveConfig, 0);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSaveConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.Location = new System.Drawing.Point(268, 308);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(101, 33);
            this.btnSaveConfig.TabIndex = 11;
            this.btnSaveConfig.Text = "Save Configuration";
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // EditNetworkDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 405);
            this.Name = "EditNetworkDialog";
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveConfig;
    }
}