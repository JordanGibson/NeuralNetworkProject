namespace SandboxUI.Controls
{
    partial class AddLayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLayerNumber = new System.Windows.Forms.Label();
            this.nudNodeCount = new System.Windows.Forms.NumericUpDown();
            this.cboActivationMethod = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.nudLearningRate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodeCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLearningRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLayerNumber
            // 
            this.lblLayerNumber.AutoSize = true;
            this.lblLayerNumber.Font = new System.Drawing.Font("Segoe UI", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLayerNumber.Location = new System.Drawing.Point(3, 4);
            this.lblLayerNumber.Name = "lblLayerNumber";
            this.lblLayerNumber.Size = new System.Drawing.Size(54, 19);
            this.lblLayerNumber.TabIndex = 0;
            this.lblLayerNumber.Text = "Layer #";
            // 
            // nudNodeCount
            // 
            this.nudNodeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNodeCount.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudNodeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNodeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNodeCount.ForeColor = System.Drawing.Color.White;
            this.nudNodeCount.Location = new System.Drawing.Point(334, 4);
            this.nudNodeCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNodeCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNodeCount.Name = "nudNodeCount";
            this.nudNodeCount.Size = new System.Drawing.Size(113, 23);
            this.nudNodeCount.TabIndex = 1;
            this.nudNodeCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboActivationMethod
            // 
            this.cboActivationMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActivationMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboActivationMethod.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboActivationMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboActivationMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActivationMethod.ForeColor = System.Drawing.Color.White;
            this.cboActivationMethod.FormattingEnabled = true;
            this.cboActivationMethod.Location = new System.Drawing.Point(63, 4);
            this.cboActivationMethod.Name = "cboActivationMethod";
            this.cboActivationMethod.Size = new System.Drawing.Size(191, 23);
            this.cboActivationMethod.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnRemove.Location = new System.Drawing.Point(453, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(33, 32);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "✘";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // nudLearningRate
            // 
            this.nudLearningRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLearningRate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudLearningRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudLearningRate.DecimalPlaces = 3;
            this.nudLearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLearningRate.ForeColor = System.Drawing.Color.White;
            this.nudLearningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLearningRate.Location = new System.Drawing.Point(260, 4);
            this.nudLearningRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLearningRate.Name = "nudLearningRate";
            this.nudLearningRate.Size = new System.Drawing.Size(68, 23);
            this.nudLearningRate.TabIndex = 5;
            this.nudLearningRate.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // AddLayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.nudLearningRate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cboActivationMethod);
            this.Controls.Add(this.nudNodeCount);
            this.Controls.Add(this.lblLayerNumber);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AddLayerControl";
            this.Size = new System.Drawing.Size(490, 36);
            ((System.ComponentModel.ISupportInitialize)(this.nudNodeCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLearningRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLayerNumber;
        private System.Windows.Forms.NumericUpDown nudNodeCount;
        private System.Windows.Forms.ComboBox cboActivationMethod;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.NumericUpDown nudLearningRate;
    }
}
