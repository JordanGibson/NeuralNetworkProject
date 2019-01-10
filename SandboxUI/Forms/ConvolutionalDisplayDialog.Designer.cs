namespace SandboxUI.Forms
{
    partial class ConvolutionalDisplayDialog : BaseDialog
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
            this.flpButtonHeaders = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStartup = new SandboxUI.DarkButton();
            this.flpConvDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLayerDetails = new System.Windows.Forms.Label();
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.flpButtonHeaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(1067, 0);
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Size = new System.Drawing.Size(1122, 40);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblLayerDetails);
            this.pnlContent.Controls.Add(this.flpConvDisplay);
            this.pnlContent.Controls.Add(this.flpButtonHeaders);
            this.pnlContent.Size = new System.Drawing.Size(1097, 687);
            // 
            // flpButtonHeaders
            // 
            this.flpButtonHeaders.Controls.Add(this.btnStartup);
            this.flpButtonHeaders.Location = new System.Drawing.Point(0, 0);
            this.flpButtonHeaders.Name = "flpButtonHeaders";
            this.flpButtonHeaders.Size = new System.Drawing.Size(1094, 85);
            this.flpButtonHeaders.TabIndex = 0;
            // 
            // btnStartup
            // 
            this.btnStartup.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnStartup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartup.ForeColor = System.Drawing.Color.White;
            this.btnStartup.Location = new System.Drawing.Point(3, 3);
            this.btnStartup.Name = "btnStartup";
            this.btnStartup.Size = new System.Drawing.Size(135, 37);
            this.btnStartup.TabIndex = 3;
            this.btnStartup.Tag = "";
            this.btnStartup.Text = "Convolutional 1";
            this.btnStartup.UseVisualStyleBackColor = true;
            this.btnStartup.Click += new System.EventHandler(this.Button_Click);
            // 
            // flpConvDisplay
            // 
            this.flpConvDisplay.Location = new System.Drawing.Point(0, 91);
            this.flpConvDisplay.Name = "flpConvDisplay";
            this.flpConvDisplay.Size = new System.Drawing.Size(1094, 562);
            this.flpConvDisplay.TabIndex = 1;
            // 
            // lblLayerDetails
            // 
            this.lblLayerDetails.AutoSize = true;
            this.lblLayerDetails.ForeColor = System.Drawing.Color.White;
            this.lblLayerDetails.Location = new System.Drawing.Point(4, 660);
            this.lblLayerDetails.Name = "lblLayerDetails";
            this.lblLayerDetails.Size = new System.Drawing.Size(52, 21);
            this.lblLayerDetails.TabIndex = 2;
            this.lblLayerDetails.Text = "label1";
            // 
            // ConvolutionalDisplayDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 746);
            this.Name = "ConvolutionalDisplayDialog";
            this.Text = "ConvolutionalDisplayDialog";
            this.Load += new System.EventHandler(this.ConvolutionalDisplayDialog_Load);
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.flpButtonHeaders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpButtonHeaders;
        private System.Windows.Forms.FlowLayoutPanel flpConvDisplay;
        private DarkButton btnStartup;
        private System.Windows.Forms.Label lblLayerDetails;
    }
}