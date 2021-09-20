using Ideo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Ideo.ModelViews
{
   public class UserViewModel
    {
        public ObservableCollection<User> GetUsers()
        {
            int i = 0;
            ObservableCollection<User> users = new ObservableCollection<User>();
            //GetUsers = new ObservableCollection<User>();
            for (i = 0; i < Users.Count; i++)
            {
                users.Add(Users[i]);
            }

            return users;
        }
        public UserViewModel()
        {
            GetUsers();
        }
        public List<User> Users = new List<User>()
        {
            new User{Id=Guid.NewGuid(),Name="Andrea",Description="Ciao sono Andrea e mi occupo di rompere i coglioni",Username="CozzaroNero",Password="123",Age=22,ImagePath="https://cdn.vegaoo.it/images/rep_art/gra/221/3/221357/gilet-pirata-adulto.jpg"},
            new User{Id=Guid.NewGuid(),Name="Gabriele",Description="Ciao sono Gabriele e mi occupo di rompere i coglioni",Username="Gabbuzzo",Password="123",Age=22,ImagePath="https://static.wikia.nocookie.net/leagueoflegends/images/1/1b/Malphite_Render.png/revision/latest?cb=20210521171852"},
            new User{Id=Guid.NewGuid(),Name="Vanessa",Description="Ciao sono Vanessa e mi occupo di rompere i coglioni",Username="vanish00",Password="123",Age=21,ImagePath="https://images-2.wuaki.tv/system/shots/193126/original/snapshot-1590662816.jpeg"},
        };
    }
}
