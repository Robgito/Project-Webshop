using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.API.Data.Entities
{
    public class BasketEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; }

        [Range(0, 9999, ErrorMessage = "The shipping price can't go below 0!")]
        public double ShippingPrice { get; set; }

        public List<BasketProductEntity> ListProducts { get; set; }
    }
}