using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_Bai2 
{
    public partial class Bai2 : Form
    {
        private Thread serverThread;
        private Socket listenerSocket;

        public Bai2()
        {
            InitializeComponent();
        }

        // Hàm nhận dữ liêu từ client 
        private void ReceiveData(Socket clientSocket)       
        {
            int bytesReceived = 0;
            byte[] receive = new byte[1024];
            if (listView1.InvokeRequired)
            {
                listView1.Invoke((MethodInvoker)delegate
                {
                    // Thông báo có client mới đã kết nối 
                    listView1.Items.Add("New Client Connected");
                });
            }
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(receive);
                    text += Encoding.UTF8.GetString(receive, 0, bytesReceived);
                } while (text[text.Length - 1] != '\n');

                if (listView1.InvokeRequired)
                {
                    listView1.Invoke((MethodInvoker)delegate
                    {
                        listView1.Items.Add(text);
                    });
                }
            }
        }

        // Hàm bắt đầu lắng nghe kết nối 
        private void StartListen()
        {
            listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            // Lắng nghe tại tất cả các địa chỉ IP trên máy và cổng 8080
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 8080);

            listenerSocket.Bind(iPEndPoint);
            listenerSocket.Listen(5);

            while (true)
            {
                var clientSocket = listenerSocket.Accept();
                Thread thread = new Thread(() => ReceiveData(clientSocket));
                thread.Start();
            }
        }

        // Xử lý sự kiện nhất nút Listen
        private void btnListen_Click(object sender, EventArgs e)
        {
            // Bắt đầu lắng nghe kết nối 
            serverThread = new Thread(StartListen);
            serverThread.Start();
            btnListen.Text = "Listening...";
        }

        // Xử lý sự kiện khi form đóng
        private void Bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
