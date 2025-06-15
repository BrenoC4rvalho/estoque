using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class InventoryItem
    {

        public int Id { get; set; }

        [Required]
        public int StoreId { get; set; }

        [ValidateNever]
        public Store Store { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ValidateNever]
        public Product Product { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be zero or a positive number.")]
        public int Quantity { get; set; }

    }
}
