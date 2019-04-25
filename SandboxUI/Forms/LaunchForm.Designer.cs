namespace SandboxUI.Forms
{
    partial class LaunchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaunchForm));
            this.pnlXorProblem = new System.Windows.Forms.Panel();
            this.txtXor = new System.Windows.Forms.RichTextBox();
            this.pbxXor = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMnistProblem = new System.Windows.Forms.Panel();
            this.txtMnist = new System.Windows.Forms.RichTextBox();
            this.pbxMnist = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLaunchXOR = new SandboxUI.DarkButton();
            this.btnMnistLaunch = new SandboxUI.DarkButton();
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlXorProblem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxXor)).BeginInit();
            this.pnlMnistProblem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMnist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(645, -4);
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Size = new System.Drawing.Size(721, 40);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnLaunchXOR);
            this.pnlContent.Controls.Add(this.btnMnistLaunch);
            this.pnlContent.Controls.Add(this.pnlMnistProblem);
            this.pnlContent.Controls.Add(this.pnlXorProblem);
            this.pnlContent.Size = new System.Drawing.Size(684, 677);
            // 
            // pnlXorProblem
            // 
            this.pnlXorProblem.Controls.Add(this.txtXor);
            this.pnlXorProblem.Controls.Add(this.pbxXor);
            this.pnlXorProblem.Controls.Add(this.panel2);
            this.pnlXorProblem.Location = new System.Drawing.Point(3, 4);
            this.pnlXorProblem.Name = "pnlXorProblem";
            this.pnlXorProblem.Size = new System.Drawing.Size(336, 604);
            this.pnlXorProblem.TabIndex = 0;
            // 
            // txtXor
            // 
            this.txtXor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtXor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXor.ForeColor = System.Drawing.Color.White;
            this.txtXor.Location = new System.Drawing.Point(4, 326);
            this.txtXor.Name = "txtXor";
            this.txtXor.ReadOnly = true;
            this.txtXor.Size = new System.Drawing.Size(328, 275);
            this.txtXor.TabIndex = 3;
            this.txtXor.TabStop = false;
            this.txtXor.Text = resources.GetString("txtXor.Text");
            // 
            // pbxXor
            // 
            this.pbxXor.Image = ((System.Drawing.Image)(resources.GetObject("pbxXor.Image")));
            this.pbxXor.Location = new System.Drawing.Point(7, 6);
            this.pbxXor.Name = "pbxXor";
            this.pbxXor.Size = new System.Drawing.Size(318, 318);
            this.pbxXor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxXor.TabIndex = 2;
            this.pbxXor.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(338, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 567);
            this.panel2.TabIndex = 1;
            // 
            // pnlMnistProblem
            // 
            this.pnlMnistProblem.Controls.Add(this.txtMnist);
            this.pnlMnistProblem.Controls.Add(this.pbxMnist);
            this.pnlMnistProblem.Controls.Add(this.panel3);
            this.pnlMnistProblem.Location = new System.Drawing.Point(344, 3);
            this.pnlMnistProblem.Name = "pnlMnistProblem";
            this.pnlMnistProblem.Size = new System.Drawing.Size(336, 604);
            this.pnlMnistProblem.TabIndex = 1;
            // 
            // txtMnist
            // 
            this.txtMnist.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMnist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMnist.ForeColor = System.Drawing.Color.White;
            this.txtMnist.Location = new System.Drawing.Point(4, 326);
            this.txtMnist.Name = "txtMnist";
            this.txtMnist.ReadOnly = true;
            this.txtMnist.Size = new System.Drawing.Size(328, 275);
            this.txtMnist.TabIndex = 3;
            this.txtMnist.TabStop = false;
            this.txtMnist.Text = resources.GetString("txtMnist.Text");
            // 
            // pbxMnist
            // 
            this.pbxMnist.Image = ((System.Drawing.Image)(resources.GetObject("pbxMnist.Image")));
            this.pbxMnist.Location = new System.Drawing.Point(9, 8);
            this.pbxMnist.Name = "pbxMnist";
            this.pbxMnist.Size = new System.Drawing.Size(318, 318);
            this.pbxMnist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMnist.TabIndex = 2;
            this.pbxMnist.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(338, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 567);
            this.panel3.TabIndex = 1;
            // 
            // btnLaunchXOR
            // 
            this.btnLaunchXOR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLaunchXOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchXOR.ForeColor = System.Drawing.Color.White;
            this.btnLaunchXOR.Location = new System.Drawing.Point(2, 614);
            this.btnLaunchXOR.Name = "btnLaunchXOR";
            this.btnLaunchXOR.Size = new System.Drawing.Size(336, 60);
            this.btnLaunchXOR.TabIndex = 3;
            this.btnLaunchXOR.Text = "Launch XOR";
            this.btnLaunchXOR.UseVisualStyleBackColor = true;
            this.btnLaunchXOR.Click += new System.EventHandler(this.btnLaunchXOR_Click);
            // 
            // btnMnistLaunch
            // 
            this.btnMnistLaunch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMnistLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMnistLaunch.ForeColor = System.Drawing.Color.White;
            this.btnMnistLaunch.Location = new System.Drawing.Point(344, 614);
            this.btnMnistLaunch.Name = "btnMnistLaunch";
            this.btnMnistLaunch.Size = new System.Drawing.Size(336, 60);
            this.btnMnistLaunch.TabIndex = 2;
            this.btnMnistLaunch.Text = "Launch MNIST";
            this.btnMnistLaunch.UseVisualStyleBackColor = true;
            this.btnMnistLaunch.Click += new System.EventHandler(this.btnMnistLaunch_Click);
            // 
            // LaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 749);
            this.Name = "LaunchForm";
            this.Text = "LaunchForm";
            this.Load += new System.EventHandler(this.LaunchForm_Load);
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlXorProblem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxXor)).EndInit();
            this.pnlMnistProblem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMnist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlXorProblem;
        public System.Windows.Forms.RichTextBox txtXor;
        public System.Windows.Forms.PictureBox pbxXor;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel pnlMnistProblem;
        public System.Windows.Forms.RichTextBox txtMnist;
        public System.Windows.Forms.PictureBox pbxMnist;
        public System.Windows.Forms.Panel panel3;
        public DarkButton btnLaunchXOR;
        public DarkButton btnMnistLaunch;
    }
}