using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab4
{
    public partial class Bai7_DangKy : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Bai7_DangKy()
        {
            InitializeComponent();
        }

        public async Task RegisterUser()
        {
            try
            {
                int sexValue;
                if (rbtnMale.Checked)
                {
                    sexValue = 0; // Giới tính là nam
                }
                else
                {
                    sexValue = 1; // Giới tính là nữ
                }
                string url = "https://nt106.uitiot.vn/api/v1/user/signup";

                var data = new
                {
                    username = txtUserName.Text,
                    password = txtPass.Text,
                    email = txtEmail.Text,
                    first_name = txtFirstName.Text,
                    last_name = txtLastName.Text,
                    phone = txtPhone.Text,
                    birth = dateTimePicker1.Value.ToString(),
                    language = comboBox1.SelectedItem.ToString(),
                    sex = sexValue,

                };
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                // Tạo nội dung yêu cầu
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Gửi yêu cầu POST đến API
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Xử lý phản hồi từ API
                if (response.IsSuccessStatusCode)
                {
                    // Đăng ký thành công
                    MessageBox.Show("Đăng ký thành công!");
                }
                else
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show("Đăng ký thất bại. Lỗi: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            this.Close();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            await RegisterUser();
        }
    }
}