using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }


        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Year")]
        [Required]
        public DateTime? ReleaseYear { get; set; }

        [Display(Name = "Number In Stock")]
        [Required]
        [Range(1, 20)]
        public short? NumberInStock { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        public int GenreId { get; set; }

        public string Title
        {
            get
            {
                if (Id == 0)
                    return "Add Movie";
                return "Edit Movie";
            }
        }
        
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseYear = movie.ReleaseYear;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
            DateAdded = movie.DateAdded;
        }
    }
}