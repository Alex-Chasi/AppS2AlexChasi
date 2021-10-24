using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS2AlexChasi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            
            //Navegacion entre ventanas
            MainPage = new NavigationPage(new login());

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
