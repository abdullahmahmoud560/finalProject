using System.Linq.Expressions;
using Domain.Interfaces;
using Infrastructure.ApplicationDbContext;
using Microsoft.EntityFrameworkCore; 

namespace Infrastructure.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly DB _db;

        public RepositoryBase(DB db)
        {
            _db = db;
        }

        public async Task AddAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            _db.Set<T>().Update(entity);
        }

        public async Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> func)
        {
            return await _db.Set<T>().Where(func).ToListAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

    }
}
