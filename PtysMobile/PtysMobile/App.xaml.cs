using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("MilkyNice.ttf", Alias = "MilkyNice")]
namespace PtysMobile
{
    public partial class App : Application
    {
        List<object> _shoppCart2 = new List<object>();
        public static List<object> _shoppCart { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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

        private void ShoppingCart_Clicked(object sender, EventArgs e)
        {
            MainPage = new NavigationPage(new pageShoppingCart());
        }
    }
}
