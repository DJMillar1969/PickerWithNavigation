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
            browser.VerticalOptions = LayoutOptions.FillAndExpand;
            browser.HorizontalOptions = LayoutOptions.FillAndExpand;

            BoxView adBox = new BoxView
            {
                BackgroundColor = Color.FromHex("FF2296F3"),
                HeightRequest = 60,
                VerticalOptions = LayoutOptions.End
            };


            var layout = new StackLayout();
            layout.Children.Add(browser);
            layout.Children.Add(adBox);
            
            
            
            Content = layout;
         

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}