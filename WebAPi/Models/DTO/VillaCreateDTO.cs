﻿using System.ComponentModel.DataAnnotations;

namespace WebAPi.Models.DTO
{
    public class VillaCreateDTO
    {
        [Required]
        [MaxLength(30)]
        [MinLength(5)]
        public String Name { get; set; }
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
        public String Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public String ImageUrl { get; set; }
        public String Amenity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
