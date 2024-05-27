using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class UserRepository : GenericRepo<UserEntity>, IUserRepository
    {
        private WebshopDBContext _dbContext;
        public UserRepository(WebshopDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserEntity> GetUserByIDAsync(int id)
        {
            return await _dbContext.Users
                .Include(x => x.Basket)
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<UserEntity>> GetAllUsersAsync()
        {
            return await _dbContext.Users
                .Include(x => x.Basket)
                .ToArrayAsync();
        }
    }
}
