using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class CategoryRepository : GenericRepo<CategoryEntity>
    {
        public CategoryRepository(WebshopDBContext dbContext) : base(dbContext)
        {
        }
    }
}