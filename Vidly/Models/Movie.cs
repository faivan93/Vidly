﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Display(Name="Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Required]
        [Display(Name="Number in Stock")]
        public int NumberInStock { get; set; }
    }
}