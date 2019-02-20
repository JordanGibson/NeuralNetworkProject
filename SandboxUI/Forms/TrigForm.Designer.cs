namespace SandboxUI.Forms
{
    partial class TrigForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFunction = new System.Windows.Forms.Label();
            this.cboFunction = new System.Windows.Forms.ComboBox();
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlNetworkConfiguration.SuspendLayout();
            this.pnlNetworkTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisualRepresentation)).BeginInit();
            this.pnlTrainingStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(1265, 0);
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimizeWindow.Location = new System.Drawing.Point(1155, 0);
            // 
            // btnMaximizeWindow
            // 
            this.btnMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMaximizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMaximizeWindow.Location = new System.Drawing.Point(1210, 0);
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Size = new System.Drawing.Size(1320, 40);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Size = new System.Drawing.Size(1295, 825);
            this.pnlContent.Controls.SetChildIndex(this.panel1, 0);
            this.pnlContent.Controls.SetChildIndex(this.pnlNetworkConfiguration, 0);
            this.pnlContent.Controls.SetChildIndex(this.pbxVisualRepresentation, 0);
            this.pnlContent.Controls.SetChildIndex(this.pnlNetworkTraining, 0);
            this.pnlContent.Controls.SetChildIndex(this.pnlTrainingStatus, 0);
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
            // btnTrainX
            // 
            this.btnTrainX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTrainX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // btnTrain2000
            // 
            this.btnTrain2000.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTrain2000.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(125)))));
            // 
            // btnTrain500
            // 
            this.btnTrain500.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTrain500.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(125)))), ((int)(((byte)(64)))));
            // 
            // btnSaveNetwork
            // 
            this.btnSaveNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(125)))), ((int)(((byte)(64)))));
            // 
            // btnLoadNetwork
            // 
            this.btnLoadNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoadNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(125)))), ((int)(((byte)(64)))));
            // 
            // btnCancelTraining
            // 
            this.btnCancelTraining.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelTraining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFunction);
            this.panel1.Controls.Add(this.cboFunction);
            this.panel1.Location = new System.Drawing.Point(596, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 260);
            this.panel1.TabIndex = 10;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(3, 2);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(121, 25);
            this.lblFunction.TabIndex = 10;
            this.lblFunction.Text = "Trig Function";
            // 
            // cboFunction
            // 
            this.cboFunction.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFunction.ForeColor = System.Drawing.Color.White;
            this.cboFunction.FormattingEnabled = true;
            this.cboFunction.Location = new System.Drawing.Point(9, 42);
            this.cboFunction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboFunction.Name = "cboFunction";
            this.cboFunction.Size = new System.Drawing.Size(295, 33);
            this.cboFunction.TabIndex = 10;
            this.cboFunction.SelectedValueChanged += new System.EventHandler(this.cboFunction_SelectedValueChanged);
            // 
            // TrigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 884);
            this.Name = "TrigForm";
            this.Text = "TrigForm";
            this.Load += new System.EventHandler(this.TrigForm_Load);
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlNetworkConfiguration.ResumeLayout(false);
            this.pnlNetworkConfiguration.PerformLayout();
            this.pnlNetworkTraining.ResumeLayout(false);
            this.pnlNetworkTraining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisualRepresentation)).EndInit();
            this.pnlTrainingStatus.ResumeLayout(false);
            this.pnlTrainingStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboFunction;
        public System.Windows.Forms.Label lblFunction;
    }
}