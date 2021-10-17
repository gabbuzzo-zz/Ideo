using IdeoRestfulService.Context;
using IdeoRestfulService.Models;
using IdeoRestfulService.Services;
using IdeoRestfulService.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IdeoRestfulService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ApplicationDbContext context = new ApplicationDbContext();
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public UserController(UserManager<User> userManager,SignInManager<User>signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email,
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return Ok(user);
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return Ok(model);
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);

                if (result.Succeeded)
                {
                    AuthenticationJWTBearer bearer = new AuthenticationJWTBearer();
                    byte[] inputBytes = Encoding.UTF8.GetBytes(user.Password);
                    var algorithm = new SHA256CryptoServiceProvider();
                    byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

                    var strPassHash=BitConverter.ToString(hashedBytes);
                    var userTo=context.Users.Where(x => x.Email == user.Email && x.PasswordHash == strPassHash).First();
                    string s=bearer.Authenticate(userTo);
                    return Ok(s);
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return Ok(user);
        }
        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return Ok();
        }
    }
}