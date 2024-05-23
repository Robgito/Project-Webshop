using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.API.Data.Entities
{
    public class SmartphoneEntity : IProductEntity
    {
        [Key] //Primary Key
        public int ID { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required]
        public double Price { get; set; } //real code decimal

        public string? Image { get; set; }

        [Required]
        public int Stock { get; set; }

        public int? MemoryCapacity { get; set; }

        public string? Colour { get; set; }

        public double? ScreenSize { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public int BrandID { get; set; }

        public int CategoryID { get; set; }

        public BrandEntity Brand { get; set; }

        public CategoryEntity Category { get; set; }

        public List<BasketProductEntity> ProductsInBaskets { get; set; }

        public List<OrderProductEntity> ProductsInOrders { get; set; }
    }
}