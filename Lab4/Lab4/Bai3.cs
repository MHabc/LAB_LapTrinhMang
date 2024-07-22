using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Xml.Linq;
using System.Net.Http;
using HtmlAgilityPack;
using System.IO;
namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private async Task Initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await Initizated();
            if (!string.IsNullOrEmpty(txtDomain.Text))
                webView21.CoreWebView2.Navigate(txtDomain.Text.Trim());
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private async void btnDownSources_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string downloadFolderPath = folderBrowserDialog.SelectedPath;
                    string html = await webView21.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML;");
                    html = System.Text.RegularExpressions.Regex.Unescape(html);
                    await AccessToWebsite(html, downloadFolderPath);
                }
                else
                {
                    MessageBox.Show("No folder selected. Download cancelled.");
                }
            }
        }

        private void SaveHtmlToFile(string html, string downloadFolderPath)
        {
            try
            {
                string fileName = "index.html";
                string filePath = Path.Combine(downloadFolderPath, fileName);
                File.WriteAllText(filePath, html);
                MessageBox.Show($"HTML file saved to {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving HTML file: {ex.Message}");
            }
        }

        private async Task AccessToWebsite(string html, string downloadFolderPath)
        {
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(html);

            var imageNodes = htmlDoc.DocumentNode.Descendants("img")
                            .Select(img => img.GetAttributeValue("src", null))
                            .Where(src => !string.IsNullOrEmpty(src))
                            .ToList();

            HttpClient httpClient = new HttpClient();
            foreach (var imageUrl in imageNodes)
            {
                await DownloadImageAsync(httpClient, imageUrl, downloadFolderPath);
            }
        }

        private async Task DownloadImageAsync(HttpClient httpClient, string imageUrl, string downloadFolderPath)
        {
            try
            {
                if (!Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute))
                {
                    var baseUri = new Uri(txtDomain.Text.Trim());
                    imageUrl = new Uri(baseUri, imageUrl).ToString();
                }
                byte[] imageBytes = await httpClient.GetByteArrayAsync(imageUrl);
                string fileName = Path.GetFileName(new Uri(imageUrl).LocalPath);
                string localPath = Path.Combine(downloadFolderPath, fileName);
                File.WriteAllBytes(localPath, imageBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading image: {ex.Message}");
            }
        }

        private async void btnDownFile_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string downloadFolderPath = folderBrowserDialog.SelectedPath;
                    string html = await webView21.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML;");
                    html = System.Text.RegularExpressions.Regex.Unescape(html);
                    SaveHtmlToFile(html, downloadFolderPath);
                }
                else
                {
                    MessageBox.Show("No folder selected. Download cancelled.");
                }
            }
        }
    }
}