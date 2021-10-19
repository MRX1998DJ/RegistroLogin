using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegistroLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VIewsAcceso.InicioPage());
            //MainPage = new InicioPage();

            //Background color
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Aquamarine);

            
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
