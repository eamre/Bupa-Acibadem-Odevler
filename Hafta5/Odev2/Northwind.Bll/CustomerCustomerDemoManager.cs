using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class CustomerCustomerDemoManager : BllBase<CustomerCustomerDemo, DtoCustomerCustomerDemo>, ICustomerCustomerDemoService
    {
        public readonly ICustomerCustomerDemoRepository customerCustomerDemoRepository;

        public CustomerCustomerDemoManager(IServiceProvider service) : base(service)
        {
            customerCustomerDemoRepository = service.GetService<ICustomerCustomerDemoRepository>();
        }
    
    
    }
}
