using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.DTO
{
    public class AddBasketDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        [Range(0, 9999, ErrorMessage = "The shipping price can't go below 0!")]
        public double ShippingPrice { get; set; }
    }
}