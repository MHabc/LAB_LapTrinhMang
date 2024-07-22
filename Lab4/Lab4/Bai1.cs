using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        // Bắt sự kiện Click cho nút GET
        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = txbURL.Text;
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    string htmlContent = GetHTML(url);
                    richTextBox1.Text = htmlContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid URL !");
            }
        }

        // Hàm lấy dữ liệu HTML từ URL
        private string GetHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }
    }
}
