using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Bai7 : Form
    {
        Bai7_DangKy bai7_dangky = new Bai7_DangKy();
        Bai7_DangNhap bai7_dangnhap = new Bai7_DangNhap();
        Bai7_ThemMon bai7_themmon = new Bai7_ThemMon();
        public static class TokenVariables
        {
            public static string TokenVar { get; set; }
        }
        public Bai7()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bai7_dangnhap.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            bai7_dangky.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bai7_themmon.Show();
        }
        public async Task GetDataAndDisplay(string token)
        {
            using (var client = new HttpClient())
            {
                TokenVariables.TokenVar = token;
                btnDangNhap.Visible = false;
                btnDangKy.Visible = false;
                btnAdd.Visible = true;
                btnRandom.Visible = true;
                var data = new
                {
                    current = 1,
                    pageSize = 100,
                };
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                // Tạo nội dung yêu cầu
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                using (var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/all", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var responseData = await response.Content.ReadAsStringAsync();
                        // Chuyển đổi dữ liệu JSON thành danh sách các món ăn
                        MonAnResponse root = JsonConvert.DeserializeObject<MonAnResponse>(responseData);
                        List<MonAn> monAnList = root.Data;
                        //List<MonAn> monAnList = JsonConvert.DeserializeObject<List<MonAn>>(responseData);
                        // Hiển thị dữ liệu trên TabPage
                        DisplayDataInTabPage(monAnList);

                    }
                    else
                    {
                        MessageBox.Show("Lấy dữ liệu thất bại!" + response.ReasonPhrase);
                    }
                }
            }
        }

        public async Task tpMe_Click_()
        {
            using (var client = new HttpClient())
            {
                string token = TokenVariables.TokenVar;
                var data = new
                {
                    current = 1,
                    pageSize = 5,
                };
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                // Tạo nội dung yêu cầu
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                using (var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/my-dishes", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var responseData = await response.Content.ReadAsStringAsync();
                        // Chuyển đổi dữ liệu JSON thành danh sách các món ăn
                        MonAnResponse root2 = JsonConvert.DeserializeObject<MonAnResponse>(responseData);
                        List<MonAn> monAnList2 = root2.Data;
                        //List<MonAn> monAnList = JsonConvert.DeserializeObject<List<MonAn>>(responseData);
                        // Hiển thị dữ liệu trên TabPage
                        DisplayDataInTabPage2(monAnList2);

                    }
                    else
                    {
                        MessageBox.Show("Lấy dữ liệu thất bại!" + response.ReasonPhrase);
                    }
                }
            }
        }

        private void DisplayDataInTabPage(List<MonAn> monAnList)
        {
            // Tạo một Control (ví dụ: DataGridView) để hiển thị dữ liệu
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoGenerateColumns = true;
            // Thiết lập nguồn dữ liệu cho DataGridView
            dataGridView.DataSource = monAnList;
            // Thêm DataGridView vào TabPage
            tpAll.Controls.Add(dataGridView);
            // Thêm TabPage vào TabControl
        }

        private void DisplayDataInTabPage2(List<MonAn> monAnList)
        {
            // Tạo một Control (ví dụ: DataGridView) để hiển thị dữ liệu
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoGenerateColumns = true;
            // Thiết lập nguồn dữ liệu cho DataGridView
            dataGridView.DataSource = monAnList;
            // Thêm DataGridView vào TabPage
            tpMe.Controls.Add(dataGridView);
            // Thêm TabPage vào TabControl
        }
        // Class đại diện cho đối tượng món ăn
        public class MonAn
        {
            public string Id { get; set; }
            public string Ten_Mon_An { get; set; }
            public decimal Gia { get; set; }
            public string Mo_Ta { get; set; }
            public string Hinh_Anh { get; set; }
            public string Dia_Chi { get; set; }
            public string Nguoi_Dong_Gop { get; set; }
        }

        public class Pagination
        {
            public int Current { get; set; }
            public int PageSize { get; set; }
            public int Total { get; set; }
        }

        public class MonAnResponse
        {
            public List<MonAn> Data { get; set; }
            public Pagination Pagination { get; set; }
        }

        private void tpMe_Click(object sender, EventArgs e)
        {
            tpMe_Click_();
        }

        private async void btnRandom_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                string token = TokenVariables.TokenVar;
                Random random = new Random();
                int iId = random.Next(1, 249);
                string id = iId.ToString();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                string url = $"https://nt106.uitiot.vn/api/v1/monan/{id}";
                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var responseData = await response.Content.ReadAsStringAsync();
                        JObject dataObject = JObject.Parse(responseData);

                        // Lấy các giá trị từ dữ liệu JSON
                        string name = dataObject["ten_mon_an"].ToString();
                        string price = dataObject["gia"].ToString();
                        string description = dataObject["mo_ta"].ToString();
                        string imageUrl = dataObject["hinh_anh"].ToString();
                        string address = dataObject["dia_chi"].ToString();
                        string contributor = dataObject["nguoi_dong_gop"].ToString();

                        string message = $"Tên: {name}\nGiá: {price}\nMô tả: {description}\nHình ảnh: {imageUrl}\nĐịa chỉ: {address}\nNgười đóng góp: {contributor}";
                        MessageBox.Show(message, "Thông tin món ăn");
                    }
                    else
                    {
                        MessageBox.Show("Lấy dữ liệu thất bại!" + response.ReasonPhrase);
                    }
                }
            }
        }
    }
}