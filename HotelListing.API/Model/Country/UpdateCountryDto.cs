using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Model.Country
{
    public class UpdateCountryDto : BaseCountryDto
    {
        [Required]
        public int Id { get; set; }

    }
}