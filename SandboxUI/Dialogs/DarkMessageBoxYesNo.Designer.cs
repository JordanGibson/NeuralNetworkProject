namespace SandboxUI.Dialogs
{
    partial class DarkMessageBoxYesNo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.btnNo = new System.Windows.Forms.Button();
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Size = new System.Drawing.Size(486, 137);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(353, 187);
            this.btnOk.Text = "Yes";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(529, 0);
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Size = new System.Drawing.Size(518, 40);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(493, 134);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(194, 187);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(153, 30);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // DarkMessageBoxYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 225);
            this.Controls.Add(this.btnNo);
            this.Name = "DarkMessageBoxYesNo";
            this.Text = "DarkMessageBoxYesNo";
            this.Controls.SetChildIndex(this.pnlWindowBar, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnNo, 0);
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnNo;
    }
}