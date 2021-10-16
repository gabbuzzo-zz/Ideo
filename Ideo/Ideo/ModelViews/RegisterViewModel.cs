using Ideo.Models;
using Ideo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ideo.ModelViews
{
    public class RegisterViewModel
    {
        private readonly ApiServices _apiServices = new ApiServices();

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password e conferma Password non combaciano.")]
        public string ConfirmPassword { get; set; }
        public const string GrantPassword = "grant_password";
        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var isRegistered = await _apiServices.RegisterUserAsync
                        (Email, Password, ConfirmPassword);
                    var api = new IdeoInstance();
                    api.Username = Email;
                    api.Password = Password;
                    //Settings.Username = Username;
                    //Settings.Password = Password;

                    if (isRegistered)
                    {
                        Debug.WriteLine("success");
                    }
                    else
                    {
                        Debug.WriteLine("");
                    }
                });
            }
        }

    }
}
