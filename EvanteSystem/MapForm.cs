using DevExpress.Map.Native;
using DevExpress.Utils;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvanteSystem
{
    public partial class MapForm : Form
    {
        //private WebView2 webView;
        private WebView2 webView;
        public string SelectedLocation { get; set; }

        public MapForm()
        {
            InitializeComponent();
            InitializeWebView();
        }
        private void InitializeWebView()
        {
            webView = new WebView2();
            webView.Dock = DockStyle.Top;
            webView.Height = 400; // أو حسب الحاجة
            this.Controls.Add(webView);
            webView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
        }
        private void WebView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            webView.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
        }

        private void CoreWebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string placeName = e.TryGetWebMessageAsString();
            txtLocation.Text = placeName;
        }
        private void MapForm_Load(object sender, EventArgs e)
        {
            webView = new WebView2();

            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            webView.Source = new Uri("https://www.google.com/maps");
            webView.EnsureCoreWebView2Async(null);

            //string path = Path.Combine(Application.StartupPath, "map.html");
            //webView.Source = new Uri(path);
            //webView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;

            //string path = Path.Combine(Application.StartupPath, "map.html");
            //webView.Source = new Uri(path);
        }

     


        private void btnSavelLocation_Click(object sender, EventArgs e)
        {
            SelectedLocation = txtLocation.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dashboardViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
