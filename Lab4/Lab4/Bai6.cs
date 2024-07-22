using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Lab4
{
    public partial class Bai6 : Form
    {
        Uri infoURL = new Uri("https://nt106.uitiot.vn/api/v1/user/me");
        Uri tokenURL = new Uri("https://nt106.uitiot.vn/auth/token");
        String result = "";
        public Bai6()
        {
            InitializeComponent();
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            txturl.Text = "https://nt106.uitiot.vn/api/v1/user/me";
        }

        public async Task AuthAndGetInfo(String username, String password)
        {
            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };
                var response = await client.PostAsync(tokenURL, content);
                var responseString = await response.Content.ReadAsStringAsync();
                var responseObject = JObject.Parse(responseString);
                if (!response.IsSuccessStatusCode)
                {
                    var detail = responseObject["detail"].ToString();
                    Console.WriteLine($"Detail: {detail}");
                    result = $"Error: {detail}";
                    return;
                }
                var tokenType = responseObject["token_type"].ToString();
                var accessToken = responseObject["access_token"].ToString();
                client.DefaultRequestHeaders.Authorization = new
                System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                var getUserResponse = await client.GetAsync(infoURL);
                var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
                JObject dataObject = JObject.Parse(getUserResponseString);

                string name = dataObject["username"].ToString();
                string email = dataObject["email"].ToString();
                string firstname = dataObject["first_name"].ToString();
                string lastname = dataObject["last_name"].ToString();
                string sex = dataObject["sex"].ToString();
                string language = dataObject["language"].ToString();
                string phone = dataObject["phone"].ToString();

                string message = $"Tên: {name}\nEmail: {email}\nFirst Name: {firstname}\nLast Name: {lastname}\nGiới tính: {sex}\nNgôn ngữ: {language}\nSĐT: {phone}";

                result = message + "\n" + $"Auth Token : {accessToken}";
            }
        }

        private async void btnGetInfo_Click(object sender, EventArgs e)
        {
            String username = usernameInput.Text.ToString();
            String password = passwordInput.Text.ToString();
            await AuthAndGetInfo(username, password); 
            userInfo.Text = result;
        }
    }
}