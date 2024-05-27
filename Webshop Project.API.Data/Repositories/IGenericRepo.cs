using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data.Repositories
{
    public interface IGenericRepo<T> where T : IEntity
    {
        Task AddItemAsync(T Item);
        Task DeleteItemByIDAsync(T Item);
        Task<IEnumerable<T>> GetAllItemAsync();
        Task<T> GetItemByIDAsync(int id);
        Task UpdateItemAsync(T Item);
    }
}
