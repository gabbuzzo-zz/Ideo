using Ideo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
[assembly: ExportFont("BestSchoolOutline.otf", Alias = "BSRegular")]

namespace Ideo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new EnjoyPage();
            
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
