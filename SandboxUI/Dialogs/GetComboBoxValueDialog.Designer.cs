namespace SandboxUI.Dialogs
{
    partial class GetComboBoxValueDialog
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboValue = new System.Windows.Forms.ComboBox();
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(249, 0);
            this.btnCloseWindow.Visible = false;
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Size = new System.Drawing.Size(310, 20);
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.Size = new System.Drawing.Size(0, 23);
            this.lblWindowTitle.Text = "";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.cboValue);
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.btnConfirm);
            this.pnlContent.Controls.Add(this.lblMessage);
            this.pnlContent.Location = new System.Drawing.Point(13, 30);
            this.pnlContent.Size = new System.Drawing.Size(282, 130);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(17, 15);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(55, 23);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(170, 84);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 34);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(69, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboValue
            // 
            this.cboValue.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboValue.ForeColor = System.Drawing.Color.White;
            this.cboValue.FormattingEnabled = true;
            this.cboValue.Location = new System.Drawing.Point(21, 44);
            this.cboValue.Name = "cboValue";
            this.cboValue.Size = new System.Drawing.Size(242, 31);
            this.cboValue.TabIndex = 4;
            // 
            // GetComboBoxValueDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 172);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "GetComboBoxValueDialog";
            this.Text = "FillValueForm";
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnConfirm;
        public System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.ComboBox cboValue;
    }
}