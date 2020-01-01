using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UltimateConvertor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage(string file, string title)
        {
            InitializeComponent();
            Title = title;
            var browser = new WebView();
            
            var htmlSource = new HtmlWebViewSource();
            var _fileName = file;
            htmlSource.Html = @"<html><body>
                                <iframe src='" + _fileName + @"' frameborder='0' width='100%' height='100%'/>
                                </body>
                                </html>";
            browser.Source = htmlSource;
            
            Content = browser;
         

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}