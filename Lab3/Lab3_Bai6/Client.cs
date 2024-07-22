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
using System.Xml.Linq;

namespace Lab3_Bai6
{
    public partial class Client : Form
    {
        TcpClient client;
        NetworkStream stream;
        private Thread receiveThread;
        public Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo và kết nối tới server
                client = new TcpClient();
                client.Connect("127.0.0.1", 8080);
                stream = client.GetStream();
                btnConnect.Enabled = false;

                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != "")
            {
                try
                {
                    string userName = txtName.Text;
                    string message = userName + ":" + txtMessage.Text + "\n";
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    txtMessage.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\n");
                }
            }
            else
            {
                MessageBox.Show("Error: Vui lòng nhập nội dung");
            }
        }

        private void ReceiveMessages()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead).TrimEnd('\n');

                        if (listView1.InvokeRequired)
                        {
                            listView1.Invoke((MethodInvoker)delegate
                            {
                                listView1.Items.Add(message);
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    break;
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtName.Text;
                string message = "Client " + userName + " quit\n";
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
    }
}