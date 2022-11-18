using AutoMapper;
using Dapper.Domain.Entities;
using Dapper.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Service.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Customer, dtoCustomer>().ReverseMap();
        }

    }
}
