using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.API.Data.Entities
{
    public interface IProductEntity : IEntity
    {
        [MinLength(1)]
        [MaxLength(100)]
        string Name { get; set; }

        [MinLength(1)]
        [MaxLength(500)]
        string Description { get; set; }

        double Price { get; set; }

        [MinLength(1)]
        [MaxLength(1000)]
        string Image { get; set; }

        int Stock { get; set; }
        int CategoryID { get; set; }
        int BrandID { get; set; }
        CategoryEntity Category { get; set; }
        BrandEntity Brand { get; set; }
        List<BasketProductEntity> ProductsInBaskets { get; set; }
        List<OrderProductEntity> ProductsInOrders { get; set; }
    }
}