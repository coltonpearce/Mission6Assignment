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
        public string Category { get; set; }
        public string MovieTitle { get; set; }
        public int YearCreated { get; set; }
        public string IsEdited { get; set; }
        public string LentTo {get; set; }
        public string Notes { get; set; }
        public string Rating { get; set; }
    }
}

//category, title, year, director, edited(t/f), Lent To, Notes
