using Microsoft.EntityFrameworkCore;

namespace Webshop_Project.API.Data.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private WebshopDBContext _dbContext;
        private DbSet<T> _dbSet;

        public GenericRepo(WebshopDBContext dBContext)
        {
            _dbContext = dBContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async Task<T> GetItemByIDAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllItemAsync()
        {
            return await _dbSet.ToArrayAsync();
        }

        public async Task AddItemAsync(T Item)
        {
            await _dbSet.AddAsync(Item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteItemByIDAsync(T Item)
        {
            _dbSet.Remove(Item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateItemAsync(T Item)
        {
            _dbSet.Update(Item);
            await _dbContext.SaveChangesAsync();
        }

        public Task MakeItemInactiveByIDAsync(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
