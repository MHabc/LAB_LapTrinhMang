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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5
{
    public partial class Bai6_SendMail : Form
    {
        string smtp = "";
        string smtp_port = "";
        string pass = "";
        public Bai6_SendMail(string username)
        {
            InitializeComponent();
            txtFrom.Text = username;
        }

        public void DataFromMain(string password, string smtp_, string smtp_port_)
        {
            pass = password;
            smtp = smtp_;
            smtp_port = smtp_port_;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string smtp_pass = pass;
            // Khởi tạo một đối tượng SmtpClient và các thuộc tính của đối tượng này
            SmtpClient client = new SmtpClient(smtp, int.Parse(smtp_port))
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(txtFrom.Text, smtp_pass),
                EnableSsl = true
            };

            // Khởi tạo một đối tượng MailMessage
            MailAddress from = new MailAddress(txtFrom.Text, txt_Name.Text);
            MailMessage message = new MailMessage()
            {
                From = from,
                Subject = txtSubject.Text,
                Body = txtBody.Text,
            };
            message.To.Add(txtTo.Text);

            if (!string.IsNullOrEmpty(txtAtta.Text))
            {
                // Tạo đối tượng Attachment từ đường dẫn được chọn
                Attachment attachment = new Attachment(txtAtta.Text);
                message.Attachments.Add(attachment);
            }

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

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtAtta.Text = openFileDialog.FileName;
            }
        }
    }
}
