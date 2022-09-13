using Bupa.Bll.Base;
using Bupa.Dal.Abstract;
using Bupa.Entity.Dto;
using Bupa.Entity.Models;
using Bupa.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Bll
{
    public class CustomerManager : BllBase<Customer, DtoCustomer>, ICustomerService
    {
        public readonly ICustomerRepository customerRepository;

        public CustomerManager(IServiceProvider service) : base(service)
        {
            customerRepository = service.GetService<ICustomerRepository>();
        }

    }
}
