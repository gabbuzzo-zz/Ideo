using Ideo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace Ideo.ModelViews
{
   public class IdeaViewModel
    {
        //public ObservableCollection<Idea>Ideas=new ObservableCollection<Idea>()
        //{
        //    new Idea{Id=Guid.NewGuid(),Title="Ido",Description="Progettiamo insieme per il futuro.",JoinUsers}
        //}
        public ObservableCollection<Post> Ideas { get { return (ObservableCollection<Post>)Posts; } set { } }
        private ObservableCollection<Post> Posts = new ObservableCollection<Post>()
        {
                new Post()
                {
                    Id=2,Description="Progetto Web Api Core C#",
                    PublishDate=DateTime.Now,
                    IsAccepted=true,
                    Tags=new List<Tag>(){
                        new Tag { Id = Guid.NewGuid(), Nome = "webapi" },
                        new Tag { Id=Guid.NewGuid(),Nome="csharp" }
                        },
                    Title="Web Api Core c#"
                },
                new Post()
                {
                    Id=3,Description="Progetto Xamarin forms C#",
                    PublishDate=DateTime.Now,
                    IsAccepted=true,
                    Tags=new List<Tag>(){
                        new Tag { Id = Guid.NewGuid(), Nome = "webapi" },
                        new Tag { Id = Guid.NewGuid(), Nome = "xamarin" },
                        new Tag { Id=Guid.NewGuid(),Nome="csharp" }
                        },
                    Title="Xamarin forms c#"
                }

        };
        public IdeaViewModel()
        {
            var obj = JsonConvert.SerializeObject(Posts[0]);
            Debug.WriteLine(obj);
        }
    }
}
