using System;
using DIT_ui.Auth;
using DIT_ui.Tabs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DIT_ui
{
    public partial class App : Application
    {
        public App()
        {
            LiveReload.Init();
            InitializeComponent();

            MainPage = new NavigationPage(new Signup())
            {
               
                BarBackgroundColor = Color.FromHex("#082631"),
                BarTextColor = Color.FromHex("#FFFFFF")

            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
