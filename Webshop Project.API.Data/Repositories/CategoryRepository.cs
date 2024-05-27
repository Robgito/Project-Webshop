using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
