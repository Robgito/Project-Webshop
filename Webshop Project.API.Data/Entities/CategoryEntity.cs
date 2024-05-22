
namespace Webshop_Project.API.Data.Entities
{
    public class CategoryEntity : IEntity
    {
        public int ID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
    }
}