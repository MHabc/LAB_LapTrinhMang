using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_Bai5
{
    public partial class Server : Form
    {
        private Thread serverThread;
        private Socket listenerSocket;
        private List<string> str = new List<string>();

        public Server()
        {
            InitializeComponent();
            str.Add("Bun bo"); 
            str.Add("Com tam");
            str.Add("Chao");
            str.Add("Lau hai san");
        }

        // Hàm nhận dữ liệu từ client
        private void ReceiveData(Socket clientSocket)
        {
            int bytesReceived = 0;
            byte[] receive = new byte[1024];

            if (listView1.InvokeRequired)
            {
                listView1.Invoke((MethodInvoker)delegate
                {
                    listViewUser.Items.Add("Server started!");
                    string clientAddress = ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString();
                    int clientPort = ((IPEndPoint)clientSocket.RemoteEndPoint).Port;
                    listViewUser.Items.Add($"Connection accepted from {clientAddress}:{clientPort}");
                });
            }
            while (clientSocket.Connected)
            {
                string text = "";

                bytesReceived = clientSocket.Receive(receive);
                text += Encoding.UTF8.GetString(receive, 0, bytesReceived);

                if (text.Equals("random"))
                {
                    if (str.Count > 0)
                    {
                        Random random = new Random();
                        int randomIndex = random.Next(str.Count);
                        string item = "";
                        item = str[randomIndex];
                        clientSocket.Send(Encoding.UTF8.GetBytes(item));
                    }
                    else
                    {
                        clientSocket.Send(Encoding.UTF8.GetBytes("List view is empty!"));
                    }
                }
                else
                {
                    bool itemFound = str.Contains(text);
                    if (!itemFound)
                    {
                        clientSocket.Send(Encoding.UTF8.GetBytes("Add dish to server successfully"));
                        str.Add(text);
                        if (listView1.InvokeRequired)
                        {
                            listView1.Invoke((MethodInvoker)delegate
                            {
                                listView1.Items.Add(text);
                            });
                        }
                    }
                    else
                    {
                        clientSocket.Send(Encoding.UTF8.GetBytes("Already exist"));
                    }
                }
            }
        }

        // Hàm lắng nghe kết nối
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

        // Xử lý nút Listen
        private void btnListen_Click(object sender, EventArgs e)
        {
            // Bắt đầu lắng nghe kết nối 
            serverThread = new Thread(StartListen);
            serverThread.Start();
            btnListen.Text = "Listening...";
        }

        // Xử lý nút Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            listenerSocket.Close();
            serverThread.Join();
            serverThread.Abort();
            this.Close();
        }
    }
}
