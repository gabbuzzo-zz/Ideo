using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ideo.Models;
using Ideo.ModelViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ideo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        UserViewModel userViewModel = new UserViewModel();
        ObservableCollection<User> Users = new ObservableCollection<User>();
        public LoginPage()
        {
            InitializeComponent();
            //Users = userViewModel.GetUsers();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //var Ideas = new IdeaViewModel().Ideas;
            //var mainPage = new MainPage();
            //mainPage.BindingContext = Ideas;
            await Navigation.PushModalAsync(new MainPage());
        }

        //private async void OnLoginClick(object sender, EventArgs e)
        //{
        //    #region Flusso
        //    //if (usrName.Text == String.Empty)
        //    //{
        //    //    await DisplayAlert("Testo vuoto", "Inserisci del testo", "Ok", FlowDirection.MatchParent);
        //    //}
        //    //else
        //    //{
        //    //    int userNum = 0;
        //    //    bool Exist = false;
        //    //    for (userNum = 0; userNum < Users.Count; userNum++)
        //    //    {
        //    //        if (usrName.Text == Users[userNum].Username)
        //    //        {
        //    //            //await Navigation.PushModalAsync(new MainPage());
        //    //            PssWord.IsVisible = true;
        //    //            UserImage.Source = Users[userNum].ImagePath;
        //    //            userNum = Users.Count;
        //    //            Exist = true;
        //    //        }
        //    //    }
        //    //    if (!Exist)
        //    //    {
        //    //        await DisplayAlert("Hai sbagliato qualcosa", "Username o password non corretti", "Va bene");
        //    //    }

        //    //} 
        //    #endregion
        //    //if ()
        //    //{
        //    //    //await Navigation.PushAsync(new MainPage());
        //    //}
        //}
    }
}