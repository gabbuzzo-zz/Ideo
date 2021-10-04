using Ideo.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ideo.ModelViews
{
   public class RegisterViewModel
    {
        private readonly ApiServices _apiServices = new ApiServices();

        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Message { get; set; }
        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var isRegistered = await _apiServices.RegisterUserAsync
                        (Username, Password, ConfirmPassword);

                    //Settings.Username = Username;
                    //Settings.Password = Password;

                    if (isRegistered)
                    {
                        Message = "Success :)";
                        Debug.WriteLine(Message);
                    }
                    else
                    {
                        Message = "Please try again :'(";
                        Debug.WriteLine(Message);
                    }
                });
            }
        }
    }
}
