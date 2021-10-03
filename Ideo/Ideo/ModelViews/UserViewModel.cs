using Ideo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Ideo.ModelViews
{
   public class UserViewModel
    {
        public User DefaultUser { get { return (User)GetDefaultUser(); } }

        public User GetDefaultUser()
        {
            if (DefaultUser == null)
            {
                return new User();
            }
            return DefaultUser;
        }

        public UserViewModel()
        {
            GetDefaultUser();
        }
    }
}
