using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.API.Data.Entities
{
    public class OrderEntity : IEntity
    {
        public int ID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; }
        public double TotalPrice { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        public string City { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        public string Street { get; set; }

        public int StreetNumber { get; set; }
        public int UserID { get; set; }
        public List<OrderProductEntity> ListProducts { get; set; }
    }
}