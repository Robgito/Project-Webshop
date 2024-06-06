namespace Webshop_Project.DTO
{
    public class BasketDTO
    {
        public int ID { get; set; }

        public List<BasketProductDTO> ListProducts { get; set; }

        public double TotalPrice { get; set; }
        public double ShippingPrice { get; set; }
        public DateTime ExpectedShippingDate { get; set; }
        public double PriceWithShipping { get; set; }
    }
}