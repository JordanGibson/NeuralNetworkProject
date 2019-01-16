namespace SandboxUI.Forms
{
    partial class MNISTForm : BaseSolutionForm
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
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlNetworkConfiguration.SuspendLayout();
            this.pnlNetworkTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisualRepresentation)).BeginInit();
            this.pnlTrainingStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(905, 0);
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimizeWindow.Location = new System.Drawing.Point(795, 0);
            // 
            // btnMaximizeWindow
            // 
            this.btnMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMaximizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMaximizeWindow.Location = new System.Drawing.Point(850, 0);
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Size = new System.Drawing.Size(960, 40);
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlContent.Location = new System.Drawing.Point(12, 55);
            this.pnlContent.Size = new System.Drawing.Size(936, 563);
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
            this.btnTrainX.Location = new System.Drawing.Point(11, 213);
            this.btnTrainX.Size = new System.Drawing.Size(116, 37);
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
            this.btnCancelTraining.Location = new System.Drawing.Point(876, 8);
            this.btnCancelTraining.Size = new System.Drawing.Size(25, 25);
            // 
            // pnlTrainingStatus
            // 
            this.pnlTrainingStatus.Location = new System.Drawing.Point(3, 520);
            this.pnlTrainingStatus.Size = new System.Drawing.Size(904, 40);
            // 
            // pgbTrainingProgress
            // 
            this.pgbTrainingProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbTrainingProgress.Location = new System.Drawing.Point(431, 10);
            this.pgbTrainingProgress.Size = new System.Drawing.Size(439, 23);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // MNISTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 630);
            this.Name = "MNISTForm";
            this.Text = "MNISTForm";
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
            this.ResumeLayout(false);

        }

        #endregion
    }
}