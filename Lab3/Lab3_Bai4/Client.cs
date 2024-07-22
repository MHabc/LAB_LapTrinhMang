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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Lab3_Bai4
{
    public partial class Client : Form
    {
        TcpClient client;
        NetworkStream stream;
        public Client()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện click cho các ghế ngồi
        private void button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string text = button.Text;
            string FilmName = comboBox1.SelectedItem.ToString();
            labelInfo.Text = FilmName + " " + text;
        }

        // Xử lý sự kiện click cho nút Connect
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

        // Xử lý sự kiện click cho nút Buy
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (labelInfo.Text != "")
            {
                try
                {
                    string message = labelInfo.Text;
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    labelInfo.Text = "";

                    ReceiveData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\n");
                }
            }
            else
            {
                MessageBox.Show("Error: Vui lòng chọn vé và ghế");
            }
        }

        // Xử lý sự kiện click cho nút Disconnect
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtName.Text;
                string message = userName + ": quit\n";
                // Gửi chuỗi "quit" đến server để thông báo ngắt kết nối 
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n");
            }
        }

        private void ReceiveData()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int bytesRead = 0;

                // Đọc dữ liệu từ stream
                if ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
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
    }
}
