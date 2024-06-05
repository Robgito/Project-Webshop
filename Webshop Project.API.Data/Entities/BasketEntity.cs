using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webshop_Project.API.Data.Entities
{
    public class BasketEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; }
        public double ShippingPrice { get; set; }
        public List<BasketProductEntity> ListProducts { get; set; }
    }
}