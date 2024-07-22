using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3
{
    public partial class UDPServer : Form
    {
        UdpClient udpServer;
        Thread serverThread;    

        public UDPServer()
        {
            InitializeComponent();
            udpServer = new UdpClient();    // tạo instance của lớp UdpClient để lắng nghe kết nối UDP 
        }

        private void btnListen_Click(object sender, EventArgs e)       // Xử lý sự kiện click cho nút Listen
        {
            int port;
            if (int.TryParse(txbPort.Text, out port))
            {
                StartListening(port);
            }
            else
            {
                MessageBox.Show("Số cổng không hợp lệ!");
            }
        }

        private void StartListening(int port)
        {
            udpServer = new UdpClient(port);
            serverThread = new Thread(new ThreadStart(ServerThreadMethod));     // tạo luồng mới để lắng nghe kết nối từ máy khách 
            serverThread.Start();
            AddMessageToListView("Server started listening on port " + port);
        }

        private void ServerThreadMethod()
        {
            try
            {
                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);     
                    byte[] receiveBytes = udpServer.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    string message = RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString();    //tạo message gồm địa chỉ IP + dữ liệu nhận được 
                    AddMessageToListView(message);  // thêm message vào listview
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show("SocketException: " + ex.Message);
            }
            finally
            {
                udpServer.Close();
            }
        }

        private void AddMessageToListView(string message)       // tạo hàm thêm message vào listview
        {
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new MethodInvoker(delegate { AddMessageToListView(message); }));
            }
            else
            {
                listView1.Items.Add(message);
            }
        }

        private void UDPServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void UDPServer_Load(object sender, EventArgs e)
        {

        }
    }
}
