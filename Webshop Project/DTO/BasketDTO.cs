using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.DTO
{
    public class BasketDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public List<BasketProductDTO> ListProducts { get; set; }

        public double TotalPrice { get; set; }
        public double ShippingPrice { get; set; }
        public DateTime ExpectedShippingDate { get; set; }
        public double PriceWithShipping { get; set; }
    }
}