using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Store
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Store name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "The store name must be between 2 and 100 characters long.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Store email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [StringLength(100, ErrorMessage = "The email must not exceed 100 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Store password is required.")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "The password must have at least 6 characters")]
        public string Password { get; set; }

        [Required]
        public int AddressId { get; set; }

        [ValidateNever]
        public Address Address { get; set; }

        [ValidateNever]
        public ICollection<InventoryItem> InventoryItems { get; set; } 

    }
}
