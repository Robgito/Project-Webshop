using Microsoft.EntityFrameworkCore;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class UserRepository : GenericRepo<UserEntity>, IUserRepository
    {
        public UserRepository(WebshopDBContext dbContext) : base(dbContext)
        {
        }

        public override async Task<UserEntity> GetItemByIDAsync(int id)
        {
            return await _dbContext.Users
                .Include(x => x.Basket)
                .ThenInclude(x => x.ListProducts)
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public override async Task<IEnumerable<UserEntity>> GetAllItemAsync()
        {
            return await _dbContext.Users
                .Include(x => x.Basket)
                .ThenInclude(x => x.ListProducts)
                .ToArrayAsync();
        }
    }
}