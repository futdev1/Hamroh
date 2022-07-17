﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hamroh.Data.IRepositories
{
    public interface IGenericRepository<T>
    { 
        Task<T> CreateAsync(T entity);
      
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);

        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        
        Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate);

        Task<T> UpdateAsync(T entity);
    }
}
