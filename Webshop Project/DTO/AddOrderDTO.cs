using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.DTO
{
    public class AddOrderDTO
    {
        public double TotalPrice { get; set; }
        public int UserID { get; set; }
        public List<OrderProductEntity> ListProducts { get; set; }
    }
}
