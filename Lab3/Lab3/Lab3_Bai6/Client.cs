using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3_Bai6
{
    public partial class Client : Form
    {
        TcpClient client;
        NetworkStream stream;
        public Client()
        {
            InitializeComponent();
        }

        // Xử lý nút Connect
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo và kết nối tới server
                client = new TcpClient();
                client.Connect("127.0.0.1", 8080);
                stream = client.GetStream();
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n");
            }
        }

        // Xử lý nút Send
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != "")
            {
                try
                {
                    string userName = txtName.Text;
                    string message = userName + ":" + txtMessage.Text + "\n";
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    txtMessage.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\n");
                }
            }
            else
            {
                MessageBox.Show("Error: Vui lòng nhập nội dung");
            }
        }
    }
}
