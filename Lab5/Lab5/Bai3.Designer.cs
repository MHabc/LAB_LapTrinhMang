namespace Lab5
{
    partial class Bai3
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvEmails = new System.Windows.Forms.DataGridView();
            this.lblTotalEmails = new System.Windows.Forms.Label();
            this.lblRecentEmails = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmails
            // 
            this.dgvEmails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmails.Location = new System.Drawing.Point(12, 93);
            this.dgvEmails.Name = "dgvEmails";
            this.dgvEmails.RowHeadersWidth = 62;
            this.dgvEmails.Size = new System.Drawing.Size(760, 355);
            this.dgvEmails.TabIndex = 0;
            // 
            // lblTotalEmails
            // 
            this.lblTotalEmails.AutoSize = true;
            this.lblTotalEmails.Location = new System.Drawing.Point(445, 35);
            this.lblTotalEmails.Name = "lblTotalEmails";
            this.lblTotalEmails.Size = new System.Drawing.Size(0, 16);
            this.lblTotalEmails.TabIndex = 1;
            // 
            // lblRecentEmails
            // 
            this.lblRecentEmails.AutoSize = true;
            this.lblRecentEmails.Location = new System.Drawing.Point(445, 58);
            this.lblRecentEmails.Name = "lblRecentEmails";
            this.lblRecentEmails.Size = new System.Drawing.Size(0, 16);
            this.lblRecentEmails.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 7);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(108, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(632, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 51);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // Bai3
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRecentEmails);
            this.Controls.Add(this.lblTotalEmails);
            this.Controls.Add(this.dgvEmails);
            this.Name = "Bai3";
            this.Text = "Bai3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn From = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEmails;
        private System.Windows.Forms.Label lblTotalEmails;
        private System.Windows.Forms.Label lblRecentEmails;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}