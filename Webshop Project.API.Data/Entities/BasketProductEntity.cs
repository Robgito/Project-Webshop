using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.API.Data.Entities
{
    public class BasketProductEntity : IEntity
    {
        public int ID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; }
        public int ProductID { get; set; }
        public SmartphoneEntity Product { get; set; }
        public int BasketID { get; set; }
        public BasketEntity Basket { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Range(0, 9999, ErrorMessage = "The amount price can't go below 0!")]
        public int Amount { get; set; }
    }
}