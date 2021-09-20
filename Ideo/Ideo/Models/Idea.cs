using System;
using System.Collections.Generic;
using System.Text;

namespace Ideo.Models
{
    public  class Idea
    {
        public Guid Id { get; set; }
        //Titolo dell'idea
        public string Title { get; set; }
        //Descrizione di ciò che vuole scrivere all'interno(di cosa si occuperà ecc..)
        public string Description { get; set; }
        //Quando è stata pubblicata l'Idea
        public DateTime PublishDate { get; set; }
        //Utenti che hanno aderito all'idea
        public List<User> JoinUsers { get; set; }
        //Immagine rappresentativa dell'Idea
        public string ImageLogo { get; set; }

    }
}
