using Ideo.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ideo.ModelViews
{
   public class LoginViewModel
    {
        private readonly ApiServices _apiServices = new ApiServices();

        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var accesstoken = await _apiServices.LoginAsync(Username, Password);
                    var ideo = new IdeoInstance().Token;
                    ideo = accesstoken;
                });
            }
        }

        public LoginViewModel()
        {
            var ideo = new IdeoInstance();

            Username = ideo.Username;
            Password = ideo.Password;
        }
    }
}
