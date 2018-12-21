using System.Drawing;
using System.Windows.Forms;

namespace SandboxUI.Forms
{
    partial class BaseSolutionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseSolutionForm));
            this.pnlWindowBar = new System.Windows.Forms.Panel();
            this.lblWindowTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnMaximizeWindow = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.bdcWindowDragger = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ellipseStyler = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlWindowBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlWindowBar.Controls.Add(this.lblWindowTitle);
            this.pnlWindowBar.Controls.Add(this.btnMinimizeWindow);
            this.pnlWindowBar.Controls.Add(this.btnMaximizeWindow);
            this.pnlWindowBar.Controls.Add(this.btnCloseWindow);
            this.pnlWindowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindowBar.Location = new System.Drawing.Point(0, 0);
            this.pnlWindowBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlWindowBar.Name = "pnlWindowBar";
            this.pnlWindowBar.Size = new System.Drawing.Size(1199, 40);
            this.pnlWindowBar.TabIndex = 0;
            this.pnlWindowBar.DoubleClick += new System.EventHandler(this.pnlWindowBar_DoubleClick);
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.AutoSize = true;
            this.lblWindowTitle.ForeColor = System.Drawing.Color.White;
            this.lblWindowTitle.Location = new System.Drawing.Point(11, 11);
            this.lblWindowTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(167, 23);
            this.lblWindowTitle.TabIndex = 3;
            this.lblWindowTitle.Text = "bunifuCustomLabel1";
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinimizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeWindow.Image")));
            this.btnMinimizeWindow.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizeWindow.Location = new System.Drawing.Point(1034, 0);
            this.btnMinimizeWindow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMinimizeWindow.Name = "btnMinimizeWindow";
            this.btnMinimizeWindow.Size = new System.Drawing.Size(55, 40);
            this.btnMinimizeWindow.TabIndex = 2;
            this.btnMinimizeWindow.UseVisualStyleBackColor = true;
            this.btnMinimizeWindow.Click += new System.EventHandler(this.btnMinimizeWindow_Click);
            // 
            // btnMaximizeWindow
            // 
            this.btnMaximizeWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMaximizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMaximizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMaximizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizeWindow.Image")));
            this.btnMaximizeWindow.Location = new System.Drawing.Point(1089, 0);
            this.btnMaximizeWindow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMaximizeWindow.Name = "btnMaximizeWindow";
            this.btnMaximizeWindow.Size = new System.Drawing.Size(55, 40);
            this.btnMaximizeWindow.TabIndex = 1;
            this.btnMaximizeWindow.UseVisualStyleBackColor = true;
            this.btnMaximizeWindow.Click += new System.EventHandler(this.btnMaximizeWindow_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseWindow.Image")));
            this.btnCloseWindow.Location = new System.Drawing.Point(1144, 0);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(55, 40);
            this.btnCloseWindow.TabIndex = 0;
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // bdcWindowDragger
            // 
            this.bdcWindowDragger.Fixed = true;
            this.bdcWindowDragger.Horizontal = true;
            this.bdcWindowDragger.TargetControl = this.pnlWindowBar;
            this.bdcWindowDragger.Vertical = true;
            // 
            // ellipseStyler
            // 
            this.ellipseStyler.ElipseRadius = 10;
            this.ellipseStyler.TargetControl = this;
            // 
            // BaseSolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1199, 869);
            this.Controls.Add(this.pnlWindowBar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BaseSolutionForm";
            this.Text = "BaseWindow";
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnCloseWindow;
        protected System.Windows.Forms.Button btnMinimizeWindow;
        protected System.Windows.Forms.Button btnMaximizeWindow;
        protected System.Windows.Forms.Panel pnlWindowBar;
        protected Bunifu.Framework.UI.BunifuDragControl bdcWindowDragger;
        protected Bunifu.Framework.UI.BunifuCustomLabel lblWindowTitle;
        private Bunifu.Framework.UI.BunifuElipse ellipseStyler;
    }
}