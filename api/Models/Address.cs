using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Address
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Street is required.")]
        [StringLength(150)]
        public string Street { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(100)]
        public string City { get; set; }

        [Required(ErrorMessage = "Neighborhood is required.")]
        [StringLength(100)]
        public String Neighborhood { get; set; }

        [Required(ErrorMessage = "Zip code is required.")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "The zipcode must be between 2 and 100 characters long.")]
        public string ZipCode { get; set; }

        [StringLength(100, ErrorMessage = "The complement must not exceed 100 characters.")]
        public string Complement { get; set; }

    }
}
