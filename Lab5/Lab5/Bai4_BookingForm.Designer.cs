using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Org.BouncyCastle.Asn1.Crmf;
using System.Drawing;

namespace Lab5
{
    partial class Bai4_BookingForm
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(13, 13);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(107, 16);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(138, 13);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 22);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 40);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 40);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Location = new System.Drawing.Point(13, 67);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(89, 16);
            this.lblSeatNumber.TabIndex = 4;
            this.lblSeatNumber.Text = "Seat Number:";
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Location = new System.Drawing.Point(138, 67);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(200, 22);
            this.txtSeatNumber.TabIndex = 5;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(10, 525);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(79, 29);
            this.btnBook.TabIndex = 6;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(10, 100);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(0, 25);
            this.lblMovieTitle.TabIndex = 7;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(10, 140);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(328, 373);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // Bai4_BookingForm
            // 
            this.ClientSize = new System.Drawing.Size(357, 567);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtSeatNumber);
            this.Controls.Add(this.lblSeatNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.pictureBox);
            this.Name = "Bai4_BookingForm";
            this.Text = "Booking Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblMovieTitle;
    }
}