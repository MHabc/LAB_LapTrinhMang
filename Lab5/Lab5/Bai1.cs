using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private string smtp_pass = "vvte hcfi zisa jxrd";
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Khởi tạo một đối tượng SmtpClient và các thuộc tính của đối tượng này
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("minhhoang19804@gmail.com", smtp_pass),
                EnableSsl = true
            };

            // Khởi tạo một đối tượng MailMessage
            MailAddress from = new MailAddress(txtFrom.Text, "Hoang");
            MailMessage message = new MailMessage()
            {
                From = from,
                Subject = txtSubject.Text,
                Body = txtBody.Text,
            };
            message.To.Add(txtTo.Text);

            try
            {
                client.Send(message);
                MessageBox.Show("The message is succesfully sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}