using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3_Bai5
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

        // Xử lý nút Send to Server
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMonAn.Text != "")
            {
                try
                {
                    string message = txtMonAn.Text;
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    txtMonAn.Text = "";
                    ReceiveDataAfterSendClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\n");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập món ăn !", "Error");
            }
        }

        private void ReceiveDataAfterSendClick()
        {
            try
            {
                // Tạo mảng byte để lưu trữ dữ liệu nhận được
                byte[] buffer = new byte[1024];
                int bytesRead = 0;

                // Đọc dữ liệu từ stream
                if ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    // Chuyển đổi dữ liệu từ byte sang string
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    // Hiển thị thông báo nhận được từ server
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n");
            }
        }

        // Xử lý nút Random
        private void btnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "random";
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);

                ReceiveDataAfterRandomClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n");
            }
        }

        private void ReceiveDataAfterRandomClick()
        {
            try
            {
                // Tạo mảng byte để lưu trữ dữ liệu nhận được
                byte[] buffer = new byte[1024];
                int bytesRead = 0;

                // Đọc dữ liệu từ stream
                if ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    // Chuyển đổi dữ liệu từ byte sang string
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    // Hiển thị thông báo nhận được từ server
                    lblMonAnHomNay.Text = message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n");
            }
        }

        // Xử lý nút Disconnect
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
