using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private RSAHelper rsaHelper;
        private const string encryptedPath = "Encrypt.txt";

        public Form1()
        {
            InitializeComponent();
            rsaHelper = new RSAHelper();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            rsaHelper.EnsureKeyPairExists();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string user = txbUser.Text;
            string password = txbPassword.Text;

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
            {
                string data = $"{user}/{password}";
                string encryptedData = rsaHelper.Encrypt(data);
                SaveToFile(encryptedData, encryptedPath);

                MessageBox.Show("Mã hóa thành công !", "Encryption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi! Mã hóa không thành công !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedData = ReadFromFile(encryptedPath);

            if (!string.IsNullOrEmpty(encryptedData))
            {
                string decryptedData = rsaHelper.Decrypt(encryptedData);
                if (!string.IsNullOrEmpty(decryptedData))
                {
                    string[] dataParts = decryptedData.Split('/');
                    if (dataParts.Length == 2)
                    {
                        txbUser.Text = dataParts[0];
                        txbPassword.Text = dataParts[1];
                    }
                    MessageBox.Show("Giải mã thành công từ Encrypt.txt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi! Giải mã không thành công từ Encrypt.txt !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveToFile(string data, string filePath)
        {
            File.WriteAllText(filePath, data);
        }

        private string ReadFromFile(string filePath)
        {
            if (File.Exists(filePath))
                return File.ReadAllText(filePath);
            else
                return null;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class RSAHelper
    {
        private const string publicKeyPath = "public_key.xml";
        private const string privateKeyPath = "private_key.xml";

        public void EnsureKeyPairExists()
        {
            if (!File.Exists(publicKeyPath) || !File.Exists(privateKeyPath))
                GenerateRSAKeyPair();
        }

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

        public string Encrypt(string data)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(File.ReadAllText(publicKeyPath));
                byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(data), true);
                return Convert.ToBase64String(encryptedData);
            }
        }

        public string Decrypt(string encryptedData)
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
    }
}
