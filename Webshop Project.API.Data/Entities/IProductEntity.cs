namespace Webshop_Project.API.Data.Entities
{
    public interface IProductEntity : IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        string Image { get; set; }
        int Stock { get; set; }
        int CategoryID { get; set; }
        int BrandID { get; set; }
        CategoryEntity Category { get; set; }
        BrandEntity Brand { get; set; }
    }
}