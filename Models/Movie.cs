using System;
using System.ComponentModel.DataAnnotations;

namespace dotNetMVC.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:yyyy-MMM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        // [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}