namespace ATMProject
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btndeposit = new System.Windows.Forms.Button();
            this.btnWithdrow = new System.Windows.Forms.Button();
            this.btnMiniStatement = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnFastCash = new System.Windows.Forms.Button();
            this.btnChangePin = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 135);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(772, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 492);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 10);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Red;
            this.lblAccountNumber.Location = new System.Drawing.Point(286, 168);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(199, 25);
            this.lblAccountNumber.TabIndex = 3;
            this.lblAccountNumber.Text = "Account Number :";
            // 
            // btndeposit
            // 
            this.btndeposit.BackColor = System.Drawing.Color.Black;
            this.btndeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeposit.ForeColor = System.Drawing.Color.White;
            this.btndeposit.Location = new System.Drawing.Point(69, 228);
            this.btndeposit.Name = "btndeposit";
            this.btndeposit.Size = new System.Drawing.Size(171, 43);
            this.btndeposit.TabIndex = 4;
            this.btndeposit.Text = "DEPOSIT";
            this.btndeposit.UseVisualStyleBackColor = false;
            this.btndeposit.Click += new System.EventHandler(this.btndeposit_Click);
            // 
            // btnWithdrow
            // 
            this.btnWithdrow.BackColor = System.Drawing.Color.Black;
            this.btnWithdrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrow.ForeColor = System.Drawing.Color.White;
            this.btnWithdrow.Location = new System.Drawing.Point(552, 228);
            this.btnWithdrow.Name = "btnWithdrow";
            this.btnWithdrow.Size = new System.Drawing.Size(171, 43);
            this.btnWithdrow.TabIndex = 7;
            this.btnWithdrow.Text = "WITHDROW";
            this.btnWithdrow.UseVisualStyleBackColor = false;
            this.btnWithdrow.Click += new System.EventHandler(this.btnWithdrow_Click);
            // 
            // btnMiniStatement
            // 
            this.btnMiniStatement.BackColor = System.Drawing.Color.Black;
            this.btnMiniStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniStatement.ForeColor = System.Drawing.Color.White;
            this.btnMiniStatement.Location = new System.Drawing.Point(552, 320);
            this.btnMiniStatement.Name = "btnMiniStatement";
            this.btnMiniStatement.Size = new System.Drawing.Size(171, 43);
            this.btnMiniStatement.TabIndex = 10;
            this.btnMiniStatement.Text = "MINI STATEMENT";
            this.btnMiniStatement.UseVisualStyleBackColor = false;
            this.btnMiniStatement.Click += new System.EventHandler(this.btnMiniStatement_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.Black;
            this.btnBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.ForeColor = System.Drawing.Color.White;
            this.btnBalance.Location = new System.Drawing.Point(552, 400);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(171, 43);
            this.btnBalance.TabIndex = 11;
            this.btnBalance.Text = "BALANCE";
            this.btnBalance.UseVisualStyleBackColor = false;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnFastCash
            // 
            this.btnFastCash.BackColor = System.Drawing.Color.Black;
            this.btnFastCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastCash.ForeColor = System.Drawing.Color.White;
            this.btnFastCash.Location = new System.Drawing.Point(69, 320);
            this.btnFastCash.Name = "btnFastCash";
            this.btnFastCash.Size = new System.Drawing.Size(171, 43);
            this.btnFastCash.TabIndex = 12;
            this.btnFastCash.Text = "FAST CASH";
            this.btnFastCash.UseVisualStyleBackColor = false;
            this.btnFastCash.Click += new System.EventHandler(this.btnFastCash_Click);
            // 
            // btnChangePin
            // 
            this.btnChangePin.BackColor = System.Drawing.Color.Black;
            this.btnChangePin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePin.ForeColor = System.Drawing.Color.White;
            this.btnChangePin.Location = new System.Drawing.Point(69, 400);
            this.btnChangePin.Name = "btnChangePin";
            this.btnChangePin.Size = new System.Drawing.Size(171, 43);
            this.btnChangePin.TabIndex = 13;
            this.btnChangePin.Text = "CHANGE PIN";
            this.btnChangePin.UseVisualStyleBackColor = false;
            this.btnChangePin.Click += new System.EventHandler(this.btnChangePin_Click);
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.LinkColor = System.Drawing.Color.Red;
            this.LogOut.Location = new System.Drawing.Point(354, 423);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(68, 20);
            this.LogOut.TabIndex = 14;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "LogOut";
            this.LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.btnChangePin);
            this.Controls.Add(this.btnFastCash);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnMiniStatement);
            this.Controls.Add(this.btnWithdrow);
            this.Controls.Add(this.btndeposit);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Button btndeposit;
        private System.Windows.Forms.Button btnWithdrow;
        private System.Windows.Forms.Button btnMiniStatement;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnFastCash;
        private System.Windows.Forms.Button btnChangePin;
        private System.Windows.Forms.LinkLabel LogOut;
    }
}