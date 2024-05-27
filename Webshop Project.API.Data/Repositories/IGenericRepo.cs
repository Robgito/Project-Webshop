namespace Webshop_Project.API.Data.Repositories
{
    public interface IGenericRepo<T>
    {
        Task AddItemAsync(T Item);
        Task DeleteItemByIDAsync(int id);
        Task<IEnumerable<T>> GetAllItemAsync();
        Task<T> GetItemByIDAsync(int id);
        Task UpdateItemAsync(T Item);
    }
}
