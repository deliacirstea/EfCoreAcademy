﻿using EfCoreAcademy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreAcademy
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetFilteredAsync(Expression<Func<T, bool>>[] filters, int? skip, int? take, params Expression<Func<T, object>>[] includes);
        Task<List<T>> GetAsync(Expression<Func<T, bool>>[] filters, int? skip, int? take, params Expression<Func<T, object>>[] includes);
        Task<T?> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes);
        Task<int> InsertAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();

    }
}
