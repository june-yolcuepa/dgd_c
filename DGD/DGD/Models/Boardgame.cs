using System;
using System.ComponentModel.DataAnnotations;

namespace DGD.Models
{
    public class Boardgame
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Designer { get; set; }

        public string Illustrator { get; set; }

        public int Year { get; set; }

        public int PlayerMin { get; set; }
        public int PlayerMax { get; set; }

        public string Notes { get; set; }

        public string Genre { get; set; }

        public string Subgenre { get; set; }

        public string Collection { get; set; }

        public string EstDuration { get; set; }

        public string GeekLink { get; set; }

        // Designer text / short
        // Illustrator     text / short
        // Year        number
        // Title       text / short
        // NOTES       text / long
        // Genre: Sub Category List
        //Collection      Category List
        //Player Min      number
        //Player Max number
        //Est.Duration text / short
        //Geek Site hyperlink
    }
}
