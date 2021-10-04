using Ideo.Models;
using Ideo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Ideo.ModelViews
{
   public class UserViewModel
    {
        public User DefaultUser { get { return (User)GetDefaultUser(); } set { } }
        private IdeoInstance _context;
        public User GetDefaultUser()
        {
            if (DefaultUser == null)
            {
                return new User();
            }
            else
            {
                var value=_context.GetAsync(Constants.RestUrl + "users/");
                var user = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(value.Result.Content.ToString());
                try
                {
                    DefaultUser = user[0];
                }
                catch(Exception ex)

                {
                    string s = ex.Message;
                    User us = new User()
                    {
                        Curriculum = "pdf",
                        Id = Guid.NewGuid(),
                        FiscalCode = "CMDOOo2349CMo",
                        Email = "admin@example.com",
                        Password = "admin",
                        Name = "Gabriele",
                        Surname = "Saracino",
                        Username = "Gabbuzzo"
                    };
                    //var header = new HttpContentHeaders().ContentType.MediaType("");

                    //HttpContent content = new HttpContent() { Headers = new System.Net.Http.Headers.HttpContentHeaders() {ContentType=ContentTy}};
                    //var response = _context.PostAsync(Constants.RestUrl + "users/");
                }
            }
            return DefaultUser;
        }

        public UserViewModel()
        {
            GetDefaultUser();
        }
    }
}
