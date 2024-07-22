using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using System.Xml.Schema;

namespace BT
{
    class RSA
    {
        clsCryptography obj;
        byte[] temp;
        FileStream fs;
        XmlSerializer xs;
        string sPub;
        string sPri;

        public RSA()
        {
            obj = new clsCryptography();
            // Gán giá trị cho sPub và sPri từ thuộc tính PublicKey và PrivateKey trong clsCryptography
            sPub = obj.PublicKey;
            sPri = obj.PrivateKey;
        }

        public void Encrypt(string data)
        {
            temp = obj.Encrypt(System.Text.Encoding.UTF8.GetBytes(data), sPub);
            xs = new XmlSerializer(temp.GetType());
            fs = File.Create(".\\Encrypt.txt");
            xs.Serialize(fs, temp);
            fs.Close();
        }

        public string Decrypt()
        {
            try
            {
                temp = System.Text.Encoding.UTF8.GetBytes("RSA");
                xs = new XmlSerializer(temp.GetType());
                fs = File.OpenRead(".\\Encrypt.txt");
                temp = (byte[])xs.Deserialize(fs);
                fs.Close();
                return System.Text.Encoding.UTF8.GetString(obj.Decrypt(temp, sPri));
            }
            catch
            {
                return null ;
            }
        }

        public class clsCryptography
        {
            private RSACryptoServiceProvider RSA;
            public string PublicKey;
            public string PrivateKey;

            public byte[] Encrypt(byte[] Data, string PublicKeyIn)
            {
                RSA.FromXmlString(PublicKeyIn);
                return RSA.Encrypt(Data, false);
            }

            public byte[] Decrypt(byte[] Data, string PrivateKeyIn)
            {
                RSA.FromXmlString(PrivateKeyIn);
                return RSA.Decrypt(Data, false);
            }

            public clsCryptography()
            {
                CspParameters csp = new CspParameters();
                csp.Flags = CspProviderFlags.UseMachineKeyStore;
                RSA = new RSACryptoServiceProvider(csp);
                PublicKey = RSA.ToXmlString(false);
                PrivateKey = RSA.ToXmlString(true);
            }
        }
    }
}
