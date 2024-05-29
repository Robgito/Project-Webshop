using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.DTO
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public DateTime Created { get; set; }
        public double TotalPrice { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public int UserID { get; set; }
        public List<OrderProductEntity> ListProducts { get; set; }
    }
}
