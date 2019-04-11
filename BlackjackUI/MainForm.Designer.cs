namespace BlackjackUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnDoubleDown = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.btnInsurance = new System.Windows.Forms.Button();
            this.lblUserTotal = new System.Windows.Forms.Label();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.nudBet = new System.Windows.Forms.NumericUpDown();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(13, 872);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(140, 68);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Location = new System.Drawing.Point(159, 872);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(140, 68);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Enabled = false;
            this.btnStand.Location = new System.Drawing.Point(305, 872);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(140, 68);
            this.btnStand.TabIndex = 3;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnDoubleDown
            // 
            this.btnDoubleDown.Enabled = false;
            this.btnDoubleDown.Location = new System.Drawing.Point(451, 872);
            this.btnDoubleDown.Name = "btnDoubleDown";
            this.btnDoubleDown.Size = new System.Drawing.Size(140, 68);
            this.btnDoubleDown.TabIndex = 4;
            this.btnDoubleDown.Text = "Double Down";
            this.btnDoubleDown.UseVisualStyleBackColor = true;
            // 
            // btnSplit
            // 
            this.btnSplit.Enabled = false;
            this.btnSplit.Location = new System.Drawing.Point(597, 872);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(140, 68);
            this.btnSplit.TabIndex = 5;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            // 
            // pnlTable
            // 
            this.pnlTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTable.BackgroundImage")));
            this.pnlTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTable.Controls.Add(this.lblResult);
            this.pnlTable.Controls.Add(this.lblDealerTotal);
            this.pnlTable.Controls.Add(this.lblUserTotal);
            this.pnlTable.Location = new System.Drawing.Point(-2, -2);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(1499, 868);
            this.pnlTable.TabIndex = 6;
            // 
            // btnInsurance
            // 
            this.btnInsurance.Enabled = false;
            this.btnInsurance.Location = new System.Drawing.Point(743, 872);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.Size = new System.Drawing.Size(140, 68);
            this.btnInsurance.TabIndex = 7;
            this.btnInsurance.Text = "Take Insurance";
            this.btnInsurance.UseVisualStyleBackColor = true;
            // 
            // lblUserTotal
            // 
            this.lblUserTotal.AutoSize = true;
            this.lblUserTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUserTotal.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTotal.ForeColor = System.Drawing.Color.White;
            this.lblUserTotal.Location = new System.Drawing.Point(755, 665);
            this.lblUserTotal.Name = "lblUserTotal";
            this.lblUserTotal.Size = new System.Drawing.Size(93, 36);
            this.lblUserTotal.TabIndex = 0;
            this.lblUserTotal.Text = "11/21";
            this.lblUserTotal.Visible = false;
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDealerTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDealerTotal.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTotal.ForeColor = System.Drawing.Color.White;
            this.lblDealerTotal.Location = new System.Drawing.Point(755, 245);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(93, 36);
            this.lblDealerTotal.TabIndex = 1;
            this.lblDealerTotal.Text = "11/21";
            this.lblDealerTotal.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(1321, 872);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(163, 25);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "Balance: £1000";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(1321, 915);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(81, 25);
            this.lblBet.TabIndex = 9;
            this.lblBet.Text = "Bet: £0";
            // 
            // btnBet
            // 
            this.btnBet.Enabled = false;
            this.btnBet.Location = new System.Drawing.Point(889, 872);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(140, 68);
            this.btnBet.TabIndex = 10;
            this.btnBet.Text = "Place Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            // 
            // nudBet
            // 
            this.nudBet.DecimalPlaces = 2;
            this.nudBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBet.Location = new System.Drawing.Point(1035, 883);
            this.nudBet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBet.Name = "nudBet";
            this.nudBet.Size = new System.Drawing.Size(120, 38);
            this.nudBet.TabIndex = 11;
            this.nudBet.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBet.ValueChanged += new System.EventHandler(this.nudBet_ValueChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(713, 728);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(103, 25);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "You Lose";
            this.lblResult.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 952);
            this.Controls.Add(this.nudBet);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnInsurance);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnDoubleDown);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnDraw);
            this.Name = "MainForm";
            this.Text = "Blackjack";
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnDoubleDown;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Button btnInsurance;
        private System.Windows.Forms.Label lblUserTotal;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.NumericUpDown nudBet;
        private System.Windows.Forms.Label lblResult;
    }
}

