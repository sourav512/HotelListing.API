﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Model.Country
{
    public abstract class BaseCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
