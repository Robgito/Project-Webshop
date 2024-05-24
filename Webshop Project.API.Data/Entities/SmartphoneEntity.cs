using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.API.Data.Entities
{
    public class SmartphoneEntity : IProductEntity
    {
        public BasketEntity Brand { get; set; }

        public int BrandID { get; set; }

        public CategoryEntity Category { get; set; }

        public int CategoryID { get; set; }

        public string? Colour { get; set; }

        public DateTime Created { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Key] //Primary Key
        public int ID { get; set; }
        public string? Image { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public int? MemoryCapacity { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        public List<BasketProductEntity> ProductsInBaskets { get; set; }
        public List<OrderProductEntity> ProductsInOrders { get; set; }
        public double? ScreenSize { get; set; }
        //real code decimal
        [Required]
        public int Stock { get; set; }

        public DateTime Updated { get; set; }
    }
}