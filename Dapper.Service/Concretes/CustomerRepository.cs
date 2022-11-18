using Dapper.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper.Domain.Entities;
using System.Linq.Expressions;
using Dapper.Data.Concretes;
using Dapper.Services.Abstracts;

namespace Dapper.Services.Concretes
{
  public  class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(dbSettings dbSettings)
            : base(dbSettings) { }


        public async Task<bool> DeleteCustomerAsync(int id)
        {
            return await DeleteAsync(id);
        }

      /*  public async Task<Customer> GetFilterCustomer(Expression<Func<Customer, bool>> filter)
        {
            return await GetFilter(filter);
        }*/

    /*    public async Task<List<Customer>> GetFilterCustomerAll(Expression<Func<Customer, bool>> filter)
        {
            return await GetFilterAll(filter);
        }
    */

        public async Task<IEnumerable<Customer>> GetCustomerAsync()
        {
            return await FindAllAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await FindByIdAsync(id);
        }

        public async Task<bool> InsertCustomerAsync(Customer customer)
        {
            return await CreateAsync(customer);
        }

        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            return await UpdateAsync(customer);
        }

       /* public async Task<int> CustomerStoredProcedure(string storedProcedure, DynamicParameters dynamicParameters)
        {
            return await GetStoredProcedure(storedProcedure, dynamicParameters);
        }
       */
        /*public async Task<List<Customer>> GetQueryCustomer(string query)
        {
            return await GetQueryAll(query);
        }*/
    }
}

