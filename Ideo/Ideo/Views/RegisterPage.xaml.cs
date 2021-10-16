using Ideo.Models;
using Ideo.ModelViews;
using Ideo.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ideo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        ApiServices _apiServices = new ApiServices();
        public RegisterPage()
        {
            InitializeComponent();
            //this.BindingContext = new RegisterViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var model=this.BindingContext as RegisterViewModel;
            var newModel = new RegisterViewModel()
            {
                Email = model.Email,
                Password = model.Password,
            };
            //await Navigation.PushModalAsync(new LoginPage() { BindingContext = newModel });
        }


    }
}