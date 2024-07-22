using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BTLop
{
    public partial class Form1 : Form
    {
        private const string publicKeyPath = "public_key.xml";
        private const string privateKeyPath = "private_key.xml";
        private const string encryptedFilePath = "Encrypt.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tạo cặp khóa RSA nếu chưa tồn tại
            if (!File.Exists(publicKeyPath) || !File.Exists(privateKeyPath))
                GenerateRSAKeyPair();
        }

        // Xử lý sự kiện khi nhấn nút Encrypt
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //Nhập thông tin user, password 
            string user = txbUser.Text;
            string password = txbPassword.Text;

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
            {
                string data = $"{user}/{password}";
                string encryptedData = EncryptData(data);
                SaveToFile(encryptedData, encryptedFilePath);

                MessageBox.Show("Encryption completed. Data saved to Encrypt.txt", "Encryption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error! Encryption incompleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi nhấn nút Decrypt
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Đọc dữ liệu cần giải mã từ file (Encrypt.txt)
            string encryptedData = ReadFromFile(encryptedFilePath);

            if (!string.IsNullOrEmpty(encryptedData))
            {
                string decryptedData = DecryptData(encryptedData);
                if (!string.IsNullOrEmpty(decryptedData))
                {
                    string[] dataParts = decryptedData.Split('/');
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
        }

        // Xử lý sự kiện khi nhấn nút Close 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tạo cặp khóa RSA
        private void GenerateRSAKeyPair()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                string publicKey = rsa.ToXmlString(false);
                string privateKey = rsa.ToXmlString(true);
                File.WriteAllText(publicKeyPath, publicKey);
                File.WriteAllText(privateKeyPath, privateKey);
            }
        }

        // Mã hóa dữ liệu 
        private string EncryptData(string data)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(File.ReadAllText(publicKeyPath));
                byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(data), true);
                return Convert.ToBase64String(encryptedData);
            }
        }

        // Giải mã dữ liệu
        private string DecryptData(string encryptedData)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(File.ReadAllText(privateKeyPath));
                    byte[] decryptedData = rsa.Decrypt(Convert.FromBase64String(encryptedData), true);
                    return Encoding.UTF8.GetString(decryptedData);
                }
            }
            catch
            {
                return null;
            }
        }

        // Lưu dữ liệu vào file 
        private void SaveToFile(string data, string filePath)
        {
            File.WriteAllText(filePath, data);
        }

        // Đọc dữ liệu từ file
        private string ReadFromFile(string filePath)
        {
            if (File.Exists(filePath))
                return File.ReadAllText(filePath);
            else
                return null;
        }
    }
}
