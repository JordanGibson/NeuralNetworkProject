namespace SandboxUI.Forms
{
    partial class NewNetworkDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreateNetwork = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvLayerConfiguration = new System.Windows.Forms.DataGridView();
            this.lblLayerNumber = new System.Windows.Forms.Label();
            this.lblActivationMethod = new System.Windows.Forms.Label();
            this.lblLearningRate = new System.Windows.Forms.Label();
            this.lblNodeCount = new System.Windows.Forms.Label();
            this.LayerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivationMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LearningRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NodeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlWindowBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayerConfiguration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCloseWindow.Location = new System.Drawing.Point(-4757, 3);
            this.btnCloseWindow.Visible = false;
            // 
            // pnlWindowBar
            // 
            this.pnlWindowBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlWindowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindowBar.Size = new System.Drawing.Size(532, 45);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblNodeCount);
            this.pnlContent.Controls.Add(this.lblLearningRate);
            this.pnlContent.Controls.Add(this.lblActivationMethod);
            this.pnlContent.Controls.Add(this.lblLayerNumber);
            this.pnlContent.Controls.Add(this.dgvLayerConfiguration);
            this.pnlContent.Controls.Add(this.btnClear);
            this.pnlContent.Controls.Add(this.btnLoadConfig);
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.btnCreateNetwork);
            this.pnlContent.Location = new System.Drawing.Point(6, 48);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.pnlContent.Size = new System.Drawing.Size(521, 348);
            // 
            // btnCreateNetwork
            // 
            this.btnCreateNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNetwork.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCreateNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNetwork.Location = new System.Drawing.Point(369, 308);
            this.btnCreateNetwork.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCreateNetwork.Name = "btnCreateNetwork";
            this.btnCreateNetwork.Size = new System.Drawing.Size(144, 33);
            this.btnCreateNetwork.TabIndex = 3;
            this.btnCreateNetwork.Text = "Create Network";
            this.btnCreateNetwork.UseVisualStyleBackColor = false;
            this.btnCreateNetwork.Click += new System.EventHandler(this.btnCreateNetwork_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(8, 308);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadConfig.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLoadConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadConfig.Location = new System.Drawing.Point(190, 308);
            this.btnLoadConfig.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(174, 33);
            this.btnLoadConfig.TabIndex = 5;
            this.btnLoadConfig.Text = "Load Configuration";
            this.btnLoadConfig.UseVisualStyleBackColor = false;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Olive;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(92, 308);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvLayerConfiguration
            // 
            this.dgvLayerConfiguration.AllowUserToResizeColumns = false;
            this.dgvLayerConfiguration.AllowUserToResizeRows = false;
            this.dgvLayerConfiguration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLayerConfiguration.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLayerConfiguration.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLayerConfiguration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayerConfiguration.ColumnHeadersVisible = false;
            this.dgvLayerConfiguration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LayerNumber,
            this.ActivationMethod,
            this.LearningRate,
            this.NodeCount});
            this.dgvLayerConfiguration.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvLayerConfiguration.EnableHeadersVisualStyles = false;
            this.dgvLayerConfiguration.GridColor = System.Drawing.Color.White;
            this.dgvLayerConfiguration.Location = new System.Drawing.Point(8, 45);
            this.dgvLayerConfiguration.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvLayerConfiguration.Name = "dgvLayerConfiguration";
            this.dgvLayerConfiguration.RowHeadersVisible = false;
            this.dgvLayerConfiguration.RowTemplate.Height = 23;
            this.dgvLayerConfiguration.Size = new System.Drawing.Size(508, 258);
            this.dgvLayerConfiguration.TabIndex = 0;
            this.dgvLayerConfiguration.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvLayerConfiguration_CellStateChanged);
            this.dgvLayerConfiguration.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvLayerConfiguration_EditingControlShowing);
            this.dgvLayerConfiguration.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvLayerConfiguration_RowsAdded);
            this.dgvLayerConfiguration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvLayerConfiguration_KeyPress);
            // 
            // lblLayerNumber
            // 
            this.lblLayerNumber.AutoSize = true;
            this.lblLayerNumber.Location = new System.Drawing.Point(14, 12);
            this.lblLayerNumber.Name = "lblLayerNumber";
            this.lblLayerNumber.Size = new System.Drawing.Size(110, 21);
            this.lblLayerNumber.TabIndex = 7;
            this.lblLayerNumber.Text = "Layer Number";
            this.lblLayerNumber.Click += new System.EventHandler(this.lblLayerNumber_Click);
            // 
            // lblActivationMethod
            // 
            this.lblActivationMethod.AutoSize = true;
            this.lblActivationMethod.Location = new System.Drawing.Point(127, 12);
            this.lblActivationMethod.Name = "lblActivationMethod";
            this.lblActivationMethod.Size = new System.Drawing.Size(137, 21);
            this.lblActivationMethod.TabIndex = 8;
            this.lblActivationMethod.Text = "Activation Method";
            this.lblActivationMethod.Click += new System.EventHandler(this.lblActivationMethod_Click);
            // 
            // lblLearningRate
            // 
            this.lblLearningRate.AutoSize = true;
            this.lblLearningRate.Location = new System.Drawing.Point(274, 12);
            this.lblLearningRate.Name = "lblLearningRate";
            this.lblLearningRate.Size = new System.Drawing.Size(106, 21);
            this.lblLearningRate.TabIndex = 9;
            this.lblLearningRate.Text = "Learning Rate";
            this.lblLearningRate.Click += new System.EventHandler(this.lblLearningRate_Click);
            // 
            // lblNodeCount
            // 
            this.lblNodeCount.AutoSize = true;
            this.lblNodeCount.Location = new System.Drawing.Point(405, 12);
            this.lblNodeCount.Name = "lblNodeCount";
            this.lblNodeCount.Size = new System.Drawing.Size(94, 21);
            this.lblNodeCount.TabIndex = 10;
            this.lblNodeCount.Text = "Node Count";
            // 
            // LayerNumber
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            this.LayerNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.LayerNumber.HeaderText = "Layer #";
            this.LayerNumber.Name = "LayerNumber";
            this.LayerNumber.ReadOnly = true;
            // 
            // ActivationMethod
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.333333F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            this.ActivationMethod.DefaultCellStyle = dataGridViewCellStyle3;
            this.ActivationMethod.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ActivationMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivationMethod.HeaderText = "Activation Method";
            this.ActivationMethod.Name = "ActivationMethod";
            this.ActivationMethod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ActivationMethod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LearningRate
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.333333F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            this.LearningRate.DefaultCellStyle = dataGridViewCellStyle4;
            this.LearningRate.HeaderText = "Learning Rate";
            this.LearningRate.Name = "LearningRate";
            // 
            // NodeCount
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.333333F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            this.NodeCount.DefaultCellStyle = dataGridViewCellStyle5;
            this.NodeCount.HeaderText = "Node Count";
            this.NodeCount.Name = "NodeCount";
            // 
            // NewNetworkDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 405);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "NewNetworkDialog";
            this.Text = "NewNetworkDialog";
            this.pnlWindowBar.ResumeLayout(false);
            this.pnlWindowBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayerConfiguration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateNetwork;
        private System.Windows.Forms.DataGridView dgvLayerConfiguration;
        private System.Windows.Forms.Label lblNodeCount;
        private System.Windows.Forms.Label lblLearningRate;
        private System.Windows.Forms.Label lblActivationMethod;
        private System.Windows.Forms.Label lblLayerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LayerNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn ActivationMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn LearningRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NodeCount;
    }
}