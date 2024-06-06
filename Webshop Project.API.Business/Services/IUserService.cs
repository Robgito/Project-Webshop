using Webshop_Project.API.Business.Models;

namespace Webshop_Project.API.Business.Services
{
    public interface IUserService
    {
        Task AddUserAsync(User user);

        Task DeleteUserAsync(int id);

        Task<User> GetUserAsync(int id);

        Task<IEnumerable<User>> GetUsersAsync();

        Task UpdateUserAsync(int id, User user);

        Task MakeUserInactiveAsync(int id);
    }
}