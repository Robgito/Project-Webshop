using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class UserRepository : GenericRepo<UserEntity>
    {
        public UserRepository(WebshopDBContext dbContext) : base(dbContext)
        {
        }

        public override async Task<UserEntity> GetItemByIDAsync(int id)
        {
            return await _dbContext.Users
                .Include(x => x.Basket)
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public override async Task<IEnumerable<UserEntity>> GetAllItemAsync()
        {
            return await _dbContext.Users
                .Include(x => x.Basket)
                .ToArrayAsync();
        }
    }
}
