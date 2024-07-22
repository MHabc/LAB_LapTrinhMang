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
using System.Net.Mail;
using System.IO;
using System.Threading;
using MailKit.Search;

namespace Lab5
{
    public partial class Bai5_Server : Form
    {
        private ImapClient client;
        public Bai5_Server()
        {
            InitializeComponent();
        }

        private void Bai5_Server_Load(object sender, EventArgs e)
        {

        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true);
            client.Authenticate("quoccuongluu03@gmail.com", label1.Text);
            dataGridView1.Columns.Add("Name", "Name");
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
                var message = inbox.GetMessage(i);
                string subject = message.Subject;

                if (subject == "Đóng góp món ăn")
                {
                    string from = message.From.ToString();
                    MailAddress mail = new MailAddress(from);
                    string name = mail.DisplayName;
                    DateTime date = message.Date.DateTime;
                    dataGridView1.Rows.Add(name, subject, from, date);
                }
                if (limit >= 5)
                {
                    break;
                }
                limit++;

            }
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count - 2;
            Random rnd = new Random();
            int randomRowIndex = rnd.Next(0, count);

            lblNguoiDongGop.Text = dataGridView1.Rows[randomRowIndex].Cells["Name"].Value.ToString();
            lblMonAn.Text = GetEmailContent(randomRowIndex);



            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);


            var message = inbox.GetMessage(inbox.Count - 1 - randomRowIndex);

            foreach (var attachment in message.Attachments)
            {
                if (attachment is MimePart)
                {
                    var mimePart = (MimePart)attachment;
                    if (mimePart.ContentType.MediaType == "application" && mimePart.IsAttachment)
                    {
                        // Xử lý tệp đính kèm hình ảnh ở đây
                        using (var memory = new MemoryStream())
                        {
                            mimePart.Content.DecodeTo(memory);
                            memory.Position = 0;
                            try
                            {
                                Image image = Image.FromStream(memory);
                                // Hiển thị hình ảnh hoặc lưu vào ổ đĩa
                                imageResult.Image = image;

                            }
                            catch (ArgumentException)
                            {

                            }
                        }
                    }
                }
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


    }
}