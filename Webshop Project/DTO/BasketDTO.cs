using System.ComponentModel.DataAnnotations;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.DTO
{
    public class BasketDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Range(0,9999, ErrorMessage = "The shipping price can't go below 0!")]
        public double ShippingPrice { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public List<BasketProductDTO> ListProducts { get; set; }
    }
}