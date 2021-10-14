using Ideo.Models;
using Ideo.ModelViews;
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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            //this.BindingContext = new RegisterViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var model=this.BindingContext as RegisterViewModel;
            var newModel = new LoginViewModel()
            {
                Username = model.Username,
                Password = model.Password,
            };
            await Navigation.PushModalAsync(new LoginPage() { BindingContext = newModel });

        }
    }
}