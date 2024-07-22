using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_Bai4
{
    public partial class Server : Form
    {
        private Thread serverThread;
        private Socket listenerSocket;
        private List<string> strings = new List<string>();
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {

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
                    listView1.Items.Add("Server started!");
                    string clientAddress = ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString();
                    int clientPort = ((IPEndPoint)clientSocket.RemoteEndPoint).Port;
                    listView1.Items.Add($"Connection accepted from {clientAddress}:{clientPort}");
                });
            }

            while (clientSocket.Connected)
            {
                string text = "";

                bytesReceived = clientSocket.Receive(receive);
                text += Encoding.UTF8.GetString(receive, 0, bytesReceived);

                bool itemFound = strings.Contains(text);
                if (!itemFound)
                {
                    clientSocket.Send(Encoding.UTF8.GetBytes("Bought ticket successfully !"));
                    strings.Add(text);
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
                    clientSocket.Send(Encoding.UTF8.GetBytes("The seat has been booked"));
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

        // Xử lý sự kiện Click cho nút Listen
        private void btnListen_Click(object sender, EventArgs e)
        {
            // Bắt đầu lắng nghe kết nối 
            serverThread = new Thread(StartListen);
            serverThread.Start();
            btnListen.Text = "Listening...";
        }

        // Xử lý sự kiện Click cho nút Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            listenerSocket.Close();
            serverThread.Join();
            serverThread.Abort();
            this.Close();
        }
    }
}
