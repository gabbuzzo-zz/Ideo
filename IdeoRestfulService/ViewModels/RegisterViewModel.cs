using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoRestfulService.ViewModels
{
    public class RegisterViewModel
    {
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
    }
}
