using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarDemoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }


        public static bool IsDevEnv
        {
            get
            {
                return false; //change this before release!
            }
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
