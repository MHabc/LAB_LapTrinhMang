namespace Lab5
{
    partial class Bai5_Client
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
            this.from = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.fromInput = new System.Windows.Forms.TextBox();
            this.toInput = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.Label();
            this.bodyInput = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.selectImageBtn = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(47, 15);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(76, 21);
            this.from.TabIndex = 0;
            this.from.Text = "FROM";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(47, 102);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(118, 21);
            this.to.TabIndex = 1;
            this.to.Text = "TO";
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(129, 12);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(258, 22);
            this.fromInput.TabIndex = 2;
            // 
            // toInput
            // 
            this.toInput.Location = new System.Drawing.Point(129, 99);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(258, 22);
            this.toInput.TabIndex = 3;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(47, 196);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(44, 16);
            this.title.TabIndex = 4;
            this.title.Text = "TITLE";
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(129, 190);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(258, 22);
            this.titleInput.TabIndex = 5;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(47, 239);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(54, 15);
            this.body.TabIndex = 6;
            this.body.Text = "BODY";
            // 
            // bodyInput
            // 
            this.bodyInput.Location = new System.Drawing.Point(129, 239);
            this.bodyInput.Name = "bodyInput";
            this.bodyInput.Size = new System.Drawing.Size(497, 240);
            this.bodyInput.TabIndex = 8;
            this.bodyInput.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(662, 603);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(119, 66);
            this.sendBtn.TabIndex = 9;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.Location = new System.Drawing.Point(662, 505);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(119, 68);
            this.selectImageBtn.TabIndex = 10;
            this.selectImageBtn.Text = "IMAGE";
            this.selectImageBtn.UseVisualStyleBackColor = true;
            this.selectImageBtn.Click += new System.EventHandler(this.selectImageBtn_Click);
            // 
            // images
            // 
            this.images.Location = new System.Drawing.Point(129, 485);
            this.images.Name = "images";
            this.images.Size = new System.Drawing.Size(497, 225);
            this.images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.images.TabIndex = 11;
            this.images.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(129, 54);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(258, 22);
            this.txtPass.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "PASS";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 22);
            this.txtName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(47, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "NAME";
            // 
            // Bai5_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 735);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.images);
            this.Controls.Add(this.selectImageBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.bodyInput);
            this.Controls.Add(this.body);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.title);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Name = "Bai5_Client";
            this.Text = "Bai5_Client";
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.TextBox fromInput;
        private System.Windows.Forms.TextBox toInput;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label body;
        private System.Windows.Forms.RichTextBox bodyInput;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button selectImageBtn;
        private System.Windows.Forms.PictureBox images;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
    }
}