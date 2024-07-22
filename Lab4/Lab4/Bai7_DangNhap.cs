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
using Newtonsoft.Json.Linq;

namespace Lab4
{
    public partial class Bai7_DangNhap : Form
    {
        public Bai7_DangNhap()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một đối tượng HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Thiết lập Base URL của API
                    client.BaseAddress = new Uri("https://nt106.uitiot.vn/auth/token");

                    // Thiết lập headers của yêu cầu HTTP
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Tạo một đối tượng chứa dữ liệu đăng nhập
                    var loginData = new Dictionary<string, string>
                    {
                        { "username", txtUserName.Text },
                        { "password", txtPass.Text }
                    };

                    // Gửi yêu cầu POST đến endpoint /token để đăng nhập
                    HttpResponseMessage response = await client.PostAsync("token", new FormUrlEncodedContent(loginData));

                    // Xác nhận xem yêu cầu đã thành công hay không
                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();
                        var responseObject = JObject.Parse(responseString);
                        // Đọc token từ phản hồi
                        //var tokenResponse = await response.Content.ReadAsStringAsync();
                        var accessToken = responseObject["access_token"].ToString();

                        // Xử lý token nhận được, có thể lưu vào biến hoặc gửi đến một lớp xử lý token khác
                        MessageBox.Show("Đăng nhập thành công!");
                        this.Close();

                        Bai7 bai7Form = Application.OpenForms.OfType<Bai7>().FirstOrDefault();
                        if (bai7Form != null)
                        {
                            // Gọi phương thức GetDataAndDisplay để lấy dữ liệu từ API và hiển thị nó trên TabPage
                            await bai7Form.GetDataAndDisplay(accessToken);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên người dùng và mật khẩu.");
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