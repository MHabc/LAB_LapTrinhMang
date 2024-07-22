using System;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MimeKit;
using System.Threading.Tasks;
using MailKit.Security;

namespace Lab5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            dgvEmails.Rows.Clear();
            dgvEmails.Columns.Clear();
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            var client = new Pop3Client();

            try
            {
                await client.ConnectAsync("pop.gmail.com", 995, SecureSocketOptions.SslOnConnect);
                await client.AuthenticateAsync(email, password);

                int totalEmails = client.GetMessageCount();
                lblTotalEmails.Text = "Total Emails: " + totalEmails.ToString();

                dgvEmails.Columns.Add("Subject", "Subject");
                dgvEmails.Columns.Add("From", "From");
                dgvEmails.Columns.Add("Date", "Date");
                dgvEmails.Columns["Subject"].ReadOnly = true;
                dgvEmails.Columns["From"].ReadOnly = true;
                dgvEmails.Columns["Date"].ReadOnly = true;

                // Duyệt qua email từ mới nhất đến cũ nhất
                for (int i = totalEmails-1; i >=0; i--)
                {
                    MimeMessage message = await client.GetMessageAsync(i);
                    dgvEmails.Rows.Add(message.Subject, message.From.ToString(), message.Date.LocalDateTime);
                }

                await client.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}