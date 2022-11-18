using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Data.Abstracts

{
   public interface IRepository<TEntity> where TEntity : class
    {
        //IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        Task<List<TEntity>> FindAllAsync();
       
        Task<TEntity> FindByIdAsync(int id);
        //  void Add(T entity);
        Task<bool> CreateAsync(TEntity entity);
        //void Update(T entity);
        Task<bool> UpdateAsync(TEntity entity);
        // void Remove(T entity);
        Task<bool> DeleteAsync(int id);

      //  Task<List<TEntity>> GetFilterAll(Expression<Func<TEntity, bool>> filter);
        //Task<TEntity> GetFilter(Expression<Func<TEntity, bool>> filter);
        //Task<List<TEntity>> GetQueryAll(string query);
        //Task<int> GetStoredProcedure(string storedProcedure, DynamicParameters dynamicParameters);

    }
}
