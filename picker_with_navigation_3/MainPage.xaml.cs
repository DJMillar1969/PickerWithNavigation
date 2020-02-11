using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using UltimateConvertor.Controls;


namespace UltimateConvertor
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage(string file, string title)
        {
            InitializeComponent();
            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();
            var _fileName = file; 
            this.Title = title; 
           

         

            htmlSource.Html = @" <iframe src='" + _fileName + @"' frameborder='0' width='100%' height='100%'/>";
            browser.Source = htmlSource;
            browser.VerticalOptions = LayoutOptions.FillAndExpand;
            browser.HorizontalOptions = LayoutOptions.FillAndExpand;
            
            var AdBox = new BoxView //AdControlView
            {
                BackgroundColor = Color.FromHex("FF2296F3"),
                HeightRequest = 65,
                VerticalOptions = LayoutOptions.End
            };


            var layout = new StackLayout();
            layout.Children.Add(browser);
            layout.Children.Add(AdBox);

            Content = layout;
                                    
        }

        private void HandleTapped(object sender, EventArgs e)
        {
            var page = new NavPage();
            Navigation.PushAsync(page);
        }
    }
}