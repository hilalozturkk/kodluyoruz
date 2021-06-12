﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DbFirstSample.Models
{
    public partial class Movie
    {
        public Movie()
        {
            MovieActors = new HashSet<MovieActor>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal? Price { get; set; }
        public string PosterPath { get; set; }
        public int? GenreId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}