﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DbFirstSample.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}