using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Lab4
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một đối tượng HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thiết lập Base URL của API
                    client.BaseAddress = new Uri("https://nt106.uitiot.vn/auth/token");
                    txtBoxURL.Text = "https://nt106.uitiot.vn/auth/token";
                    // Thiết lập headers của yêu cầu HTTP
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Tạo một đối tượng chứa dữ liệu đăng nhập
                    var loginData = new Dictionary<string, string>
                    {
                        { "username", txtBoxUsername.Text },
                        { "password", txtBoxPass.Text }
                    };

                    // Gửi yêu cầu POST đến endpoint /token để đăng nhập
                    HttpResponseMessage response = await client.PostAsync("token", new FormUrlEncodedContent(loginData));

                    var responseString = await response.Content.ReadAsStringAsync();
                    var responseObject = JObject.Parse(responseString);
                    // Xác nhận xem yêu cầu đã thành công hay không
                    if (response.IsSuccessStatusCode)
                    {
                        // Đọc token từ phản hồi
                        //var tokenResponse = await response.Content.ReadAsStringAsync();
                        var tokenType = responseObject["token_type"].ToString();
                        var accessToken = responseObject["access_token"].ToString();
                        kq.Text = $"Token Type: {tokenType}\nAccess Token: {accessToken}\n\nĐăng nhập thành công";

                        // Xử lý token nhận được, có thể lưu vào biến hoặc gửi đến một lớp xử lý token khác
                        MessageBox.Show("Đăng nhập thành công!");
                    }
                    else
                    {
                        var detail = responseObject["detail"].ToString();
                        kq.Text = $"Detail: {detail}";
                        MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên người dùng và mật khẩu.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
    }
}