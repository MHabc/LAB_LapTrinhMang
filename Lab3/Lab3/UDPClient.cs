using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class UDPClient : Form
    {
        UdpClient udpClient;

        public UDPClient()
        {
            InitializeComponent();
            udpClient = new UdpClient();    // tạo kết nối UDP
        }

        private void btnSend_Click(object sender, EventArgs e)      // Xử lý sự kiện nút Send
        {
            string IPaddr = txbIP.Text;
            int port;
            if (int.TryParse(txbPort.Text, out port))
            {
                string message = rtxbMessage.Text;

                byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                try
                {
                    udpClient.Send(sendBytes, sendBytes.Length, IPaddr, port);
                    MessageBox.Show("Đã gửi thành công !", "Thông báo");
                    rtxbMessage.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Số cổng không hợp lệ !", "Lỗi");
            }
        }

        private void UDPClient_Load(object sender, EventArgs e)
        {

        }
    }
}
