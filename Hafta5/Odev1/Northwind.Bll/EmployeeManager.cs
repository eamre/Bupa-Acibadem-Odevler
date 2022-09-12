using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class EmployeeManager : BllBase<Employee, DtoEmployee>, IEmployeeService
    {
        public readonly IEmployeeRepository employeeRepository;

        public EmployeeManager(IServiceProvider service) : base(service)
        {
            employeeRepository = service.GetService<IEmployeeRepository>();
        }
    
    }
}
