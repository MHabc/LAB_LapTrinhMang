using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Bai5_Client : Form
    {
        public Bai5_Client()
        {
            InitializeComponent();
        }

        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    // Display image in images
                    images.Image = Image.FromFile(file);

                    // Store image path in Tag property for later use
                    images.Tag = file;
                }
                catch (IOException)
                {
                    // Handle exception
                }
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (!titleInput.Text.Equals("Đóng góp món ăn"))
            {
                MessageBox.Show("Đây là ứng dụng đóng góp món ăn" +
                                "\n" +
                                "Hãy sửa lại tiêu đề email",
                                "Lỗi tiêu đề");
            }
            else
            {
                try
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                    {
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromInput.Text, txtPass.Text),
                        EnableSsl = true
                    };
                    MailAddress from;
                    if (string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        from = new MailAddress(fromInput.Text, "Người ẩn danh");
                    }
                    else
                    {
                        from = new MailAddress(fromInput.Text, txtName.Text);
                    }

                    MailMessage message = new MailMessage()
                    {
                        From = from,
                        Subject = titleInput.Text,
                        Body = bodyInput.Text,
                    };
                    message.To.Add(toInput.Text);


                    // Attach the image to the email
                    if (images.Image != null && images.Tag != null)
                    {
                        string imagePath = images.Tag.ToString();
                        if (File.Exists(imagePath))
                        {
                            Attachment attachment = new Attachment(imagePath);
                            message.Attachments.Add(attachment);
                        }
                        else
                        {
                            MessageBox.Show("Image file does not exist at the specified path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    try
                    {
                        client.Send(message);
                        MessageBox.Show("Your Mail is sent");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}