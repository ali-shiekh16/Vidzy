using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        
        [Display(Name = "Release Year")]
        [Required]
        public DateTime ReleaseYear { get; set; }
        
        [Required]
        public DateTime DateAdded { get; set; }
        
        [Display(Name = "Number In Stock")]
        [Required]
        [Range(1, 20)]
        public short NumberInStock { get; set; }
        public int NumberAvailability { get; set; }
        public Genre Genre { get; set; }
        
        [Required]
        public int GenreId { get; set; }
    }
}