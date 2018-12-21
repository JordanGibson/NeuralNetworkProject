using System.Drawing;
using System.Windows.Forms;

namespace SandboxUI.Forms
{
    partial class BaseDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDialogForm));
            this.pnlWindowBar = new System.Windows.Forms.Panel();
            this.lblWindowTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.bdcWindowDragger = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlWindowBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWindowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlWindowBar.Controls.Add(this.lblWindowTitle);
            this.pnlWindowBar.Controls.Add(this.btnCloseWindow);
            this.pnlWindowBar.Location = new System.Drawing.Point(0, 0);
            this.pnlWindowBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlWindowBar.Name = "pnlWindowBar";
            this.pnlWindowBar.Size = new System.Drawing.Size(877, 40);
            this.pnlWindowBar.TabIndex = 0;
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
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseWindow.Image")));
            this.btnCloseWindow.Location = new System.Drawing.Point(822, 0);
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
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlContent.Location = new System.Drawing.Point(13, 47);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(852, 616);
            this.pnlContent.TabIndex = 1;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(877, 675);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlWindowBar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BaseDialogForm";
            this.Text = "BaseWindow";
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.ResumeLayout(false);

        }

        //Standard color table for Dark Theme
        internal class CustomToolStripColorTable : ProfessionalColorTable
        {
            public override Color ButtonSelectedHighlight => ButtonSelectedGradientMiddle;
            public override Color ButtonSelectedHighlightBorder => ButtonSelectedBorder;
            public override Color ButtonPressedHighlight => ButtonPressedGradientMiddle;
            public override Color ButtonPressedHighlightBorder => ButtonPressedBorder;
            public override Color ButtonCheckedHighlight => ButtonCheckedGradientMiddle;
            public override Color ButtonCheckedHighlightBorder => ButtonSelectedBorder;
            public override Color ButtonPressedBorder => ButtonSelectedBorder;
            public override Color ButtonSelectedBorder => Color.FromArgb(98, 98, 98);
            public override Color ButtonCheckedGradientBegin => Color.FromArgb(144, 144, 144);
            public override Color ButtonCheckedGradientMiddle => Color.FromArgb(170, 170, 170);
            public override Color ButtonCheckedGradientEnd => Color.FromArgb(170, 170, 170);
            public override Color ButtonSelectedGradientBegin => Color.FromArgb(170, 170, 170);
            public override Color ButtonSelectedGradientMiddle => Color.FromArgb(170, 170, 170);
            public override Color ButtonSelectedGradientEnd => Color.FromArgb(170, 170, 170);
            public override Color ButtonPressedGradientBegin => Color.FromArgb(170, 170, 170);
            public override Color ButtonPressedGradientMiddle => Color.FromArgb(170, 170, 170);
            public override Color ButtonPressedGradientEnd => Color.FromArgb(170, 170, 170);
            public override Color CheckBackground => Color.FromArgb(173, 173, 173);
            public override Color CheckSelectedBackground => Color.FromArgb(173, 173, 173);
            public override Color CheckPressedBackground => Color.FromArgb(140, 140, 140);
            public override Color GripDark => Color.FromArgb(22, 22, 22);
            public override Color GripLight => Color.FromArgb(83, 83, 83);
            public override Color ImageMarginGradientBegin => Color.FromArgb(85, 85, 85);
            public override Color ImageMarginGradientMiddle => Color.FromArgb(68, 68, 68);
            public override Color ImageMarginGradientEnd => Color.FromArgb(68, 68, 68);
            public override Color ImageMarginRevealedGradientBegin => Color.FromArgb(68, 68, 68);
            public override Color ImageMarginRevealedGradientMiddle => Color.FromArgb(68, 68, 68);
            public override Color ImageMarginRevealedGradientEnd => Color.FromArgb(68, 68, 68);
            public override Color MenuStripGradientBegin => Color.FromArgb(138, 138, 138);
            public override Color MenuStripGradientEnd => Color.FromArgb(103, 103, 103);
            public override Color MenuItemSelected => Color.FromArgb(170, 170, 170);
            public override Color MenuItemBorder => Color.FromArgb(170, 170, 170);
            public override Color MenuBorder => Color.FromArgb(22, 22, 22);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(170, 170, 170);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(170, 170, 170);
            public override Color MenuItemPressedGradientBegin => Color.FromArgb(125, 125, 125);
            public override Color MenuItemPressedGradientMiddle => Color.FromArgb(125, 125, 125);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(125, 125, 125);
            public override Color SeparatorDark => Color.FromArgb(22, 22, 22);
            public override Color SeparatorLight => Color.FromArgb(62, 62, 62);
            public override Color ToolStripBorder => Color.FromArgb(22, 22, 22);
            public override Color ToolStripDropDownBackground => Color.FromArgb(60, 60, 60);
            public override Color ToolStripGradientBegin => Color.FromName("DimGray");
            public override Color ToolStripGradientMiddle => Color.FromArgb(89, 89, 89);
            public override Color ToolStripGradientEnd => Color.FromArgb(88, 88, 88);
            public override Color ToolStripContentPanelGradientBegin => Color.FromArgb(68, 68, 68);
            public override Color ToolStripContentPanelGradientEnd => Color.FromArgb(68, 68, 68);
            public override Color ToolStripPanelGradientBegin => Color.FromArgb(103, 103, 103);
            public override Color ToolStripPanelGradientEnd => Color.FromArgb(103, 103, 103);
        }

        #endregion
        protected System.Windows.Forms.Button btnCloseWindow;
        protected System.Windows.Forms.Panel pnlWindowBar;
        protected Bunifu.Framework.UI.BunifuDragControl bdcWindowDragger;
        protected Bunifu.Framework.UI.BunifuCustomLabel lblWindowTitle;
        protected Panel pnlContent;
    }
}