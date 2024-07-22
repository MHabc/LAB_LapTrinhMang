namespace Lab4
{
    partial class Bai6
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.Label();
            this.btngetInfo = new System.Windows.Forms.Button();
            this.userInfo = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.txturl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.username.Location = new System.Drawing.Point(33, 39);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(103, 19);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.password.Location = new System.Drawing.Point(33, 81);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(122, 22);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // url
            // 
            this.url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.url.Location = new System.Drawing.Point(33, 125);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(103, 27);
            this.url.TabIndex = 4;
            this.url.Text = "URL";
            // 
            // btngetInfo
            // 
            this.btngetInfo.Location = new System.Drawing.Point(650, 50);
            this.btngetInfo.Name = "btngetInfo";
            this.btngetInfo.Size = new System.Drawing.Size(107, 79);
            this.btngetInfo.TabIndex = 5;
            this.btngetInfo.Text = "Get Info";
            this.btngetInfo.UseVisualStyleBackColor = true;
            this.btngetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // userInfo
            // 
            this.userInfo.BackColor = System.Drawing.Color.White;
            this.userInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInfo.Location = new System.Drawing.Point(39, 204);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(700, 228);
            this.userInfo.TabIndex = 6;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(214, 35);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(292, 22);
            this.usernameInput.TabIndex = 7;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(214, 81);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(292, 22);
            this.passwordInput.TabIndex = 8;
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(214, 125);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(292, 22);
            this.txturl.TabIndex = 9;
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.btngetInfo);
            this.Controls.Add(this.url);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.Load += new System.EventHandler(this.Bai6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Button btngetInfo;
        private System.Windows.Forms.Label userInfo;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox txturl;
    }
}