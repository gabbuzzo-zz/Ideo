using Ideo.Models;
using Ideo.ModelViews;
using Ideo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ideo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnjoyPage : ContentPage
    {
        string fileName = "teamwork1.mp4";
        public EnjoyPage()
        {
            InitializeComponent();
            this.BindingContext = fileName;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new RegisterPage() { BindingContext=new User()});
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var user = new UserViewModel().DefaultUser;
            await Navigation.PushModalAsync(new LoginPage() { BindingContext =user });
        }
    }
}