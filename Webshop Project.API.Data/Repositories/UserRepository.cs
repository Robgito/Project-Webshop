using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private WebshopDBContext _dbContext;
        public UserRepository(WebshopDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserEntity> GetUserByIDAsync(int id)
        {
            return await _dbContext.Users
                .SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<IEnumerable<UserEntity>> GetAllUsersAsync()
        {
            return await _dbContext.Users
                .ToArrayAsync();
        }

        public async Task AddUserAsync(UserEntity userEntity)
        {
            await _dbContext.Users
                .AddAsync(userEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserByIDAsync(int id)
        {
            UserEntity userEntity = new UserEntity()
            {
                ID = id
            };

            _dbContext.Users
                .Remove(userEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(UserEntity userEntity)
        {
            _dbContext.Users
                .Update(userEntity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
