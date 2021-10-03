using Ideo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Ideo.Services;
using Ideo.ModelViews;

[assembly: ExportFont("BestSchoolOutline.otf", Alias = "BSRegular")]

namespace Ideo
{
    public partial class App : Application
    {
        private static IdeoInstance instance=new IdeoInstance();
        public App()
        {
            InitializeComponent();
            bool response = instance.IsConnected();
            if (response)
            {
                var usvModel = new UserViewModel();
                var user = usvModel.GetDefaultUser();
                if (user.Id != null)
                {
                    MainPage = new LoginPage() { BindingContext = user};
                }
                else
                {
                    MainPage = new RegisterPage() { BindingContext = user };
                }
            }
            else
            {
                MainPage = new EnjoyPage();
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
