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
            this.btnShowConvDisplay = new System.Windows.Forms.Button();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlNetworkConfiguration.SuspendLayout();
            this.pnlNetworkTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisualRepresentation)).BeginInit();
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
            // pnlNetworkConfiguration
            // 
            this.pnlNetworkConfiguration.Controls.Add(this.btnShowConvDisplay);
            this.pnlNetworkConfiguration.Controls.SetChildIndex(this.lblNetworkConfig, 0);
            this.pnlNetworkConfiguration.Controls.SetChildIndex(this.lblNetworkStructure, 0);
            this.pnlNetworkConfiguration.Controls.SetChildIndex(this.lblLearningRate, 0);
            this.pnlNetworkConfiguration.Controls.SetChildIndex(this.lblActivationMethod, 0);
            this.pnlNetworkConfiguration.Controls.SetChildIndex(this.lblCurrentError, 0);
            this.pnlNetworkConfiguration.Controls.SetChildIndex(this.btnNewNetwork, 0);
            this.pnlNetworkConfiguration.Controls.SetChildIndex(this.btnEditNetwork, 0);
            this.pnlNetworkConfiguration.Controls.SetChildIndex(this.btnClearNetwork, 0);
            this.pnlNetworkConfiguration.Controls.SetChildIndex(this.btnShowConvDisplay, 0);
            // 
            // btnClearNetwork
            // 
            this.btnClearNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearNetwork.Size = new System.Drawing.Size(135, 37);
            // 
            // btnEditNetwork
            // 
            this.btnEditNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(125)))));
            this.btnEditNetwork.Size = new System.Drawing.Size(135, 37);
            // 
            // btnNewNetwork
            // 
            this.btnNewNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(125)))), ((int)(((byte)(64)))));
            this.btnNewNetwork.Click += new System.EventHandler(this.btnNewNetwork_Click);
            // 
            // pnlNetworkTraining
            // 
            this.pnlNetworkTraining.Controls.Add(this.btnNextImage);
            this.pnlNetworkTraining.Controls.SetChildIndex(this.lblNetworkState, 0);
            this.pnlNetworkTraining.Controls.SetChildIndex(this.lblTrainedCount, 0);
            this.pnlNetworkTraining.Controls.SetChildIndex(this.lblPreviouslyTrainedCount, 0);
            this.pnlNetworkTraining.Controls.SetChildIndex(this.btnTrain500, 0);
            this.pnlNetworkTraining.Controls.SetChildIndex(this.btnTrain2000, 0);
            this.pnlNetworkTraining.Controls.SetChildIndex(this.btnTrainX, 0);
            this.pnlNetworkTraining.Controls.SetChildIndex(this.btnNextImage, 0);
            // 
            // btnTrainX
            // 
            this.btnTrainX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTrainX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTrainX.Size = new System.Drawing.Size(145, 37);
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
            // btnShowConvDisplay
            // 
            this.btnShowConvDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowConvDisplay.Enabled = false;
            this.btnShowConvDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowConvDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowConvDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowConvDisplay.Location = new System.Drawing.Point(148, 171);
            this.btnShowConvDisplay.Name = "btnShowConvDisplay";
            this.btnShowConvDisplay.Size = new System.Drawing.Size(131, 79);
            this.btnShowConvDisplay.TabIndex = 8;
            this.btnShowConvDisplay.Text = "Show Convolutional Display";
            this.btnShowConvDisplay.UseVisualStyleBackColor = true;
            this.btnShowConvDisplay.Click += new System.EventHandler(this.btnShowConvDisplay_Click);
            // 
            // btnNextImage
            // 
            this.btnNextImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNextImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNextImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextImage.Location = new System.Drawing.Point(159, 213);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(121, 37);
            this.btnNextImage.TabIndex = 9;
            this.btnNextImage.Text = "Next Image";
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // MNISTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 630);
            this.Name = "MNISTForm";
            this.Text = "MNISTForm";
            this.Load += new System.EventHandler(this.MNISTForm_Load);
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlNetworkConfiguration.ResumeLayout(false);
            this.pnlNetworkConfiguration.PerformLayout();
            this.pnlNetworkTraining.ResumeLayout(false);
            this.pnlNetworkTraining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisualRepresentation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnShowConvDisplay;
        public System.Windows.Forms.Button btnNextImage;
    }
}