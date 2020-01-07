using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
            

namespace UltimateConvertor
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
               
                var htmlSource = new HtmlWebViewSource();
                var _fileName = "ultimate_converter.html";
                
                htmlSource.Html = @"<html><body>
                                    <iframe src='" + _fileName + @"' frameborder='0' width='100%' height='100%' />
                                    </body></html>";
            
            browser.Source = htmlSource;
        }

    private void MenuItem1_Activated(object sender, EventArgs e)
        {
            var page = new NavPage();
            Navigation.PushAsync(page);
        }
    }
}
