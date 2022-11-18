using Dapper.Domain.Entities;
using Dapper.Domain;
using Dapper.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Service.DTOs;
using Dapper;
using AutoMapper;

namespace Dapper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController :  ControllerBase
    {  
        //Dependency Injection
             private readonly ICustomerRepository _customerRepository;
             private readonly IMapper _mapper;
          
         public CustomerController(ICustomerRepository customerRepository, IMapper mapper)
            {
                _customerRepository = customerRepository;
                this._mapper = mapper;
            }





            [HttpGet("{id}")]
            public async Task<IActionResult> Get(int id)
            {
               // Customer getFilter = await _customerRepository.GetFilter(a => a.Id == id);
                Customer customer = await _customerRepository.FindByIdAsync(id);
                return Ok(customer);
            }
            [HttpGet("GetAll")]
            public async Task<IActionResult> GetAll()
            {
               // int Id = 3;
                //List<Customer> getQueryAll = await _customerRepository.GetQueryAll($"select * from Customer(nolock) where Id>{Id}");
                //List<Customer> getFilterAll = await _customerRepository.GetFilterAll(a => a.Id > 2);
                List<Customer> getAll = await _customerRepository.FindAllAsync();
                return Ok(getAll);
            }
            [HttpPost("Insert")]
          
        
        public async Task<IActionResult> Insert(dtoCustomer customer)
            {
            var mappedCustomer = _mapper.Map
              <Customer
              >(customer);
                
                await _customerRepository.CreateAsync(mappedCustomer);
                return Ok(mappedCustomer);
                
            }

            
        
        [HttpDelete("Delete")]
            public async Task<IActionResult> Delete(int id)
            {
                await _customerRepository.DeleteAsync(id);
                return Ok("Customer Deleted");
            }
         
        
        [HttpPut("Update")]
        public async Task<IActionResult> Update(Customer customer)
        {
            Customer getCustomer = await _customerRepository.FindByIdAsync(customer.Id);
            if (getCustomer != null)
            {
                await _customerRepository.UpdateAsync(customer);
            }
            return Ok(customer);
        }

    }
}

