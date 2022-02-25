using Dietas_App3.Model;
using Dietas_App3.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dietas_App3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var x = DataBase.ConnectionDatabase;
            MainPage = new NavigationPage(new LoadingView());
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
