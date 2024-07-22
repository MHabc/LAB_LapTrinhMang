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

namespace Lab3_Bai6
{
    public partial class Server : Form
    {
        private Thread serverThread;
        private Socket listenerSocket;

        List<Socket> connectedSockets = new List<Socket>();
        public Server()
        {
            InitializeComponent();
        }

        private void ReceiveData(Socket clientSocket)
        {
            int bytesReceived = 0;
            byte[] receive = new byte[1024];
            if (listView1.InvokeRequired)
            {
                listView1.Invoke((MethodInvoker)delegate
                {
                    string clientAddress = ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString();
                    int clientPort = ((IPEndPoint)clientSocket.RemoteEndPoint).Port;
                    listView1.Items.Add($"New client connected from {clientAddress}:{clientPort}");
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
                foreach (Socket socket in connectedSockets)
                {
                    // Gửi tin nhắn qua socket
                    socket.Send(Encoding.UTF8.GetBytes(text));
                }
            }
        }

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
                connectedSockets.Add(clientSocket);
                Thread thread = new Thread(() => ReceiveData(clientSocket));
                thread.Start();
            }
        }
        private void btnListen_Click(object sender, EventArgs e)
        {
            // Bắt đầu lắng nghe kết nối 
            serverThread = new Thread(StartListen);
            serverThread.Start();
            btnListen.Text = "Listening...";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            listenerSocket.Close();
            serverThread.Join();
            serverThread.Abort();
            this.Close();
        }
    }
}