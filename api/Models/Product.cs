using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cost price is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Cost price must be a positive value.")]
        public decimal CostPrice { get; set; }
        
        [ValidateNever]
        public ICollection<InventoryItem> IventoryItems { get; set; }

    }
}
