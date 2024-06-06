using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IUserRepository : IGenericRepo<UserEntity>
    {
        Task<IEnumerable<UserEntity>> GetAllItemAsync();

        Task<UserEntity> GetItemByIDAsync(int id);
    }
}