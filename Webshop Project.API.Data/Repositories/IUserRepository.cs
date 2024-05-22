using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IUserRepository
    {
        Task AddUserAsync(UserEntity userEntity);
        Task DeleteUserByIDAsync(int id);
        Task<IEnumerable<UserEntity>> GetAllUsersAsync();
        Task<UserEntity> GetUserByIDAsync(int id);
        Task UpdateUserAsync(UserEntity userEntity);
    }
}