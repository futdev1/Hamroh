using Hamroh.Data.Contexts;
using Hamroh.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hamroh.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal readonly HamrohDbContext dbContext;
        internal readonly DbSet<T> dbSet;

        public GenericRepository(HamrohDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }
        public async Task<T> CreateAsync(T entity)
        {
            var entry = await dbSet.AddAsync(entity);

            return entry.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var result = await dbSet.FirstOrDefaultAsync(predicate);

            if (result == null)
                return false;
            dbSet.Remove(result);

            return true;
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            return predicate is null ? dbSet : dbSet.Where(predicate);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }

        public T UpdateAsync(T entity)
        {
            var entry = dbSet.Update(entity);

            return entry.Entity;
        }
    }
}
