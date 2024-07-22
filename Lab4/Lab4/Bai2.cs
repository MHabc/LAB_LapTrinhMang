using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        // Bắt sự kiện Click cho nút Download
        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txbURL.Text;
            string filePath = txbFilePath.Text;

            if (!string.IsNullOrEmpty(url) && !string.IsNullOrEmpty(filePath))
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(url, filePath);
                    string htmlContent = File.ReadAllText(filePath);
                    richTextBox1.Text = htmlContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid URL and file path !");
            }
        }
    }
}
