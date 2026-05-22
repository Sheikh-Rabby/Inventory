using Inventory.Data;
using Inventory.Interface;
using Inventory.Interface.RepositoryInterface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Inventory.Repository.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

       public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {


            return await _dbSet.ToListAsync();

        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public async Task<T?> GetByAsync (Expression <Func<T,bool>> condition )
        {
            return await _dbSet.FirstOrDefaultAsync(condition);
        
        }



    }
}
