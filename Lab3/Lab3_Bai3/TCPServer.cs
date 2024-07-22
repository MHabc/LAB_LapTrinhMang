using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bai3
{
    public partial class TCPServer : Form
    {
        private Thread serverThread;
        private Socket listenerSocket;

        public TCPServer()
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
                    listView1.Items.Add("Server started!");
                    string clientAddress = ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString();
                    int clientPort = ((IPEndPoint)clientSocket.RemoteEndPoint).Port;
                    listView1.Items.Add($"Connection accepted from {clientAddress}:{clientPort}");
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
        private void TCPServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
