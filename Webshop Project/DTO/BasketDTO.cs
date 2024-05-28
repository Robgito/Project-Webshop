using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.DTO
{
    public class BasketDTO
    {
        public int ID { get; set; }
        public double ShippingPrice { get; set; }
        public List<BasketProductDTO> ListProducts { get; set; }
    }
}