using Inventory.DTO;
using Inventory.Model;
using Inventory.Repository.BaseRepository;


namespace Inventory.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
