using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UltimateConvertor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage("ultimate_converter.html", "Ultimate Converter"));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
