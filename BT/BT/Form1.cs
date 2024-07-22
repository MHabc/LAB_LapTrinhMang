using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Nhập thông tin từ các textbox
            string user = txbUser.Text;
            string password = txbPassword.Text;

            // Kiểm tra nếu có dữ liệu
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
            {
                // Tạo đối tượng RSA
                RSA rsa = new RSA();

                // Mã hóa thông tin
                string encryptedData = $"{user}/{password}";
                rsa.Encrypt(encryptedData);

                MessageBox.Show("Encryption completed. Data saved to Encrypt.txt", "Encryption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error! Encryption incompleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng RSA
            RSA rsa = new RSA();

            // Giải mã thông tin từ file Encrypt.txt
            string decryptedData = rsa.Decrypt();

            // Hiển thị thông tin lên textbox
            if (decryptedData != null)
            {
                string[] dataParts = decryptedData.Split(':');
                if (dataParts.Length == 2)
                {
                    txbUser.Text = dataParts[0];
                    txbPassword.Text = dataParts[1];
                }
                MessageBox.Show("Decryption completed from Encrypt.txt", "Decryption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error! Decryption incompleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

