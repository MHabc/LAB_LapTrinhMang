using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Lab3_Bai3
{
    public partial class TCPClient : Form
    {
        TcpClient client;
        NetworkStream stream;

        public TCPClient()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện Click cho nút Connect
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
                richTextBox1.AppendText("Error: " + ex.Message + "\n");
            }
        }

        // Xử lý sự kiện Click cho nút Send
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Gửi dữ liệu đã nhập từ richTextBox1 đến server
                byte[] data = Encoding.ASCII.GetBytes(richTextBox1.Text + "\n");
                stream.Write(data, 0, data.Length);
                richTextBox1.Clear();
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("Error: " + ex.Message + "\n");
            }
        }

        // Xử lý sự kiện Click cho nút Disconnect
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Gửi chuỗi "quit" đến server để thông báo ngắt kết nối 
                byte[] data = Encoding.ASCII.GetBytes("quit\n");
                stream.Write(data, 0, data.Length);
                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("Error: " + ex.Message + "\n");
            }
        }
    }
}
