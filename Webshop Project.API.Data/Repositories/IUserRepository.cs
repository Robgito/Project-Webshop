using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserEntity>> GetAllUsersAsync();
        Task<UserEntity> GetUserByIDAsync(int id);
    }
}