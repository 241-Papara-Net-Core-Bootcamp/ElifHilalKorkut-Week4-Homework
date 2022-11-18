using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dapper.Domain.Entities;
using Dapper.Data.Abstracts;

namespace Dapper.Services.Abstracts
{ 
    public interface ICustomerRepository : IRepository<Customer>
    {
     
        Task<IEnumerable<Customer>> GetCustomerAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
        Task<bool> InsertCustomerAsync(Customer customer);
        Task<bool> UpdateCustomerAsync(Customer customer);
        Task<bool> DeleteCustomerAsync(int id);


       // Task<List<Customer>> GetFilterCustomerAll(Expression<Func<Customer, bool>> filter);
       // Task<Customer> GetFilterCustomer(Expression<Func<Customer, bool>> filter);
      //  Task<int> CustomerStoredProcedure(string storedProcedure, DynamicParameters dynamicParameters);
       // Task<List<Customer>> GetQueryCustomer(string query);
    }
}

