using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6Assignment.Models
{
    //here I am setting the columns that I want to see in my DB once they are migrated
    public class NewMovie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required]
        public string MovieTitle { get; set; }

        [Required]
        public int YearCreated { get; set; }

        [Required]
        public string Director { get; set; }

        public string IsEdited { get; set; }
        public string LentTo {get; set; }


        [MaxLength(25)]
        public string Notes { get; set; }

        [Required]
        public string Rating { get; set; }

        //foreign key creation
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}

//category, title, year, director, edited(t/f), Lent To, Notes
