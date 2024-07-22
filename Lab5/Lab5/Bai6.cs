using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using HtmlAgilityPack;

namespace Lab5
{
    public partial class Bai6 : Form
    {
        private ImapClient client;

        public Bai6()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            client = new ImapClient();
            string imap = txt_IMAP.Text;
            int imap_port = int.Parse(txt_IMAPport.Text);
            client.Connect(imap, imap_port, true);
            client.Authenticate(txt_username.Text, txt_password.Text);
            dataGridView1.Columns.Add("Subject", "Subject");
            dataGridView1.Columns.Add("From", "From");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns["Subject"].ReadOnly = true;
            dataGridView1.Columns["From"].ReadOnly = true;
            dataGridView1.Columns["Date"].ReadOnly = true;
            int limit = 0;
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            for (int i = inbox.Count - 1; i > 0; i--)
            {
                limit++;
                var message = inbox.GetMessage(i);
                string subject = message.Subject;
                string from = message.From.ToString();
                DateTime date = message.Date.DateTime;
                dataGridView1.Rows.Add(subject, from, date);
                if (limit == 5)
                {
                    break;
                }
            }
            btnLogin.Visible = false;
            btn_Send.Visible = true;
            btn_Refresh.Visible = true;
            btn_Logout.Visible = true;
            txt_username.Enabled = false;
            txt_password.Enabled = false;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            client.Disconnect(true);
            client.Dispose();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            // Xóa dữ liệu trong TextBoxes
            txt_username.Text = "";
            txt_password.Text = "";
            txt_username.Enabled = true;
            txt_password.Enabled = true;
            btnLogin.Visible = true;
            btn_Send.Visible = false;
            btn_Refresh.Visible = false;
            btn_Logout.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {

                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy thông tin về nội dung email từ dòng được chọn
                string subject = selectedRow.Cells["Subject"].Value.ToString();
                string from = selectedRow.Cells["From"].Value.ToString();
                string to = txt_username.Text;


                // Lấy thông tin nội dung email
                var emailContent = GetEmailContent(e.RowIndex);

                // Hiển thị nội dung email trên form EmailContentForm
                ShowEmailContentForm(from, to, subject, emailContent);
            }
        }

        private string GetEmailContent(int index)
        {
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            var message = inbox.GetMessage(inbox.Count - 1 - index);
            string content = "";

            // Kiểm tra xem email có phần multipart không
            if (message.Body is Multipart multipart)
            {
                // Lặp qua các phần tử trong phần multipart của email
                foreach (var part in multipart)
                {
                    // Kiểm tra xem phần tử có phải là văn bản không
                    if (part is TextPart textPart)
                    {
                        // Kiểm tra kiểu của văn bản (Plaintext hoặc Html)
                        if (textPart.ContentType.MediaType == "text" &&
                            textPart.ContentType.MediaSubtype == "plain")
                        {
                            // Lấy nội dung văn bản
                            content += textPart.Text;
                        }
                        else if (textPart.ContentType.MediaType == "text" &&
                                 textPart.ContentType.MediaSubtype == "html")
                        {
                            // Sử dụng HtmlAgilityPack để loại bỏ HTML
                            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                            htmlDoc.LoadHtml(textPart.Text);

                            // Lấy văn bản thuần túy
                            content += htmlDoc.DocumentNode.InnerText;
                        }
                    }
                }
            }
            else if (message.Body is TextPart textPart)
            {
                // Nếu email chỉ có một phần tử là văn bản
                content += textPart.Text;
            }

            return content;
        }

        private void ShowEmailContentForm(string from, string to, string subject, string emailContent)
        {
            Bai6_ReadMail emailForm = new Bai6_ReadMail(from, to, subject, emailContent);
            emailForm.Show();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Bai6_SendMail sendMail = new Bai6_SendMail(txt_username.Text);
            sendMail.DataFromMain(txt_password.Text, txt_SMTP.Text, txt_SMTPport.Text);
            sendMail.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Thực hiện lại quá trình lấy email và hiển thị lên DataGridView
            client = new ImapClient();
            string imap = txt_IMAP.Text;
            int imap_port = int.Parse(txt_IMAPport.Text);
            client.Connect(imap, imap_port, true);
            client.Authenticate(txt_username.Text, txt_password.Text);
            dataGridView1.Columns.Add("Subject", "Subject");
            dataGridView1.Columns.Add("From", "From");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns["Subject"].ReadOnly = true;
            dataGridView1.Columns["From"].ReadOnly = true;
            dataGridView1.Columns["Date"].ReadOnly = true;
            int limit = 0;
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            for (int i = inbox.Count - 1; i > 0; i--)
            {
                limit++;
                var message = inbox.GetMessage(i);
                string subject = message.Subject;
                string from = message.From.ToString();
                DateTime date = message.Date.DateTime;
                dataGridView1.Rows.Add(subject, from, date);
                if (limit == 5)
                {
                    break;
                }
            }
        }
    }
}
