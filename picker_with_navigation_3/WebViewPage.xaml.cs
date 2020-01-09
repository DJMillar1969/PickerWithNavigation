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

            //DisplayAlert("Alert", file + " " + title, "OK");

            Title = title;
            var browser = new WebView();
            
            var htmlSource = new HtmlWebViewSource();
            var _fileName = file;
            htmlSource.Html = @"<html><body>
                                <iframe src='" + _fileName + @"' frameborder='0' width='100%' height='100%'/>
                                </body>
                                </html>";


            browser.Source = htmlSource;
            browser.VerticalOptions = LayoutOptions.FillAndExpand;
            browser.HorizontalOptions = LayoutOptions.FillAndExpand;

          
            var layout = new StackLayout();
            layout.Children.Add(browser);
            layout.Children.Add(AdBox);
            
            
            
            Content = layout;
         

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}