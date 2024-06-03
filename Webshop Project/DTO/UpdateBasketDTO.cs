using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.DTO
{
    public class UpdateBasketDTO
    {

        [Required(ErrorMessage = "This field is required.")]
        [Range(1, 9999, ErrorMessage = "The shippingPrice can't go below 0!")]
        public double ShippingPrice { get; set; }
    }
}
