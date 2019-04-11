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
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisualRepresentation)).BeginInit();
            this.pnlTrainingStatus.SuspendLayout();
            this.pnlNetworkTraining.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(1231, 0);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseWindow.Size = new System.Drawing.Size(55, 50);
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimizeWindow.Location = new System.Drawing.Point(1121, 0);
            this.btnMinimizeWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimizeWindow.Size = new System.Drawing.Size(55, 50);
            // 
            // btnMaximizeWindow
            // 
            this.btnMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMaximizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMaximizeWindow.Location = new System.Drawing.Point(1176, 0);
            this.btnMaximizeWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaximizeWindow.Size = new System.Drawing.Size(55, 50);
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlWindowBar.Size = new System.Drawing.Size(1286, 50);
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(16, 69);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Size = new System.Drawing.Size(1253, 703);
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
            // pbxVisualRepresentation
            // 
            this.pbxVisualRepresentation.Location = new System.Drawing.Point(3, 269);
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
            this.btnCancelTraining.Location = new System.Drawing.Point(1204, 10);
            this.btnCancelTraining.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelTraining.Size = new System.Drawing.Size(34, 31);
            // 
            // pnlTrainingStatus
            // 
            this.pnlTrainingStatus.Location = new System.Drawing.Point(4, 650);
            this.pnlTrainingStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTrainingStatus.Size = new System.Drawing.Size(1243, 50);
            // 
            // pgbTrainingProgress
            // 
            this.pgbTrainingProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbTrainingProgress.Location = new System.Drawing.Point(593, 12);
            this.pgbTrainingProgress.Margin = new System.Windows.Forms.Padding(4);
            this.pgbTrainingProgress.Size = new System.Drawing.Size(604, 29);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnTrainX
            // 
            this.btnTrainX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTrainX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTrainX.Location = new System.Drawing.Point(15, 266);
            this.btnTrainX.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrainX.Size = new System.Drawing.Size(160, 46);
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
            // MNISTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 787);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MNISTForm";
            this.Text = "MNISTForm";
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlNetworkConfiguration.ResumeLayout(false);
            this.pnlNetworkConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisualRepresentation)).EndInit();
            this.pnlTrainingStatus.ResumeLayout(false);
            this.pnlTrainingStatus.PerformLayout();
            this.pnlNetworkTraining.ResumeLayout(false);
            this.pnlNetworkTraining.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}