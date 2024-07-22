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
using static Lab4.Bai7;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Bai7_ThemMon : Form
    {
        public Bai7_ThemMon()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                string url = "https://nt106.uitiot.vn/api/v1/monan/add";
                string token = TokenVariables.TokenVar;
                var data = new
                {
                    ten_mon_an = txtFoodName.Text,
                    gia = txtPrice.Text,
                    mo_ta = rtxtInfo.Text,
                    hinh_anh = txtImage.Text,
                    dia_chi = txtAddress.Text
                };
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                // Tạo nội dung yêu cầu
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    // Đăng ký thành công
                    MessageBox.Show("Đã thêm thành công!");
                    clear();
                    Bai7 bai7Form = Application.OpenForms.OfType<Bai7>().FirstOrDefault();
                    if (bai7Form != null)
                    {
                        // Gọi phương thức GetDataAndDisplay để lấy dữ liệu từ API và hiển thị nó trên TabPage
                        await bai7Form.tpMe_Click_();
                    }
                }
                else
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show("Thêm món thất bại. Lỗi: " + response.ReasonPhrase);
                }
            }
        }


        private void clear()
        {
            txtFoodName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtImage.Text = string.Empty;
            txtAddress.Text = string.Empty;
            rtxtInfo.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}