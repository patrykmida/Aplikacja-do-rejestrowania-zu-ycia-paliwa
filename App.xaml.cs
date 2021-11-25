using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSpalanie
{
    public partial class App : Application
    {
        public static int Lid;
        public static int Lx;
        public static string Lusername;
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
    }
}
