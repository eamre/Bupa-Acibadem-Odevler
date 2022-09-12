using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entity.IBase;
using Northwind.Entity.Base;
using Microsoft.AspNetCore.Http;

namespace Northwind.Bll
{
    public class CustomerManager : BllBase<Customer, DtoCustomer>, ICustomerService
    {
        public readonly ICustomerRepository customerRepository;

        public CustomerManager(IServiceProvider service) : base(service)
        {
            customerRepository = service.GetService<ICustomerRepository>();
        }

        public IResponse<DtoCustomer> FindCustomer(string id)
        {
            try
            {
                //var entity = repository.Find(id);
                return new Response<DtoCustomer>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Succes",
                    Data = ObjectMapper.Mapper.Map<Customer, DtoCustomer>(customerRepository.FindCustomer(id))
                };
            }
            catch (Exception ex)
            {
                return new Response<DtoCustomer>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }

        }
        public IQueryable CustomerReport()
        {
            return customerRepository.CustomerReport();
        }
    
    }
}
