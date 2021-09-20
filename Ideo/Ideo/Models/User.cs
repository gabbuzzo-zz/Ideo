using System;
using System.Collections.Generic;
using System.Text;

namespace Ideo.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        //Immagine profilo che non avra come peso 400mb.
        public string ImagePath { get; set; }

    }
}
