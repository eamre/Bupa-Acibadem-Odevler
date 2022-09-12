using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class EmployeeTerritoryManager:BllBase<EmployeeTerritory, DtoEmployeeTerritory>, IEmployeeTerritoryService
    {
        public readonly IEmployeeTerritoryRepository employeeTerritoryRepository;
    
        public EmployeeTerritoryManager(IServiceProvider service) : base(service)
        {
            employeeTerritoryRepository = service.GetService<IEmployeeTerritoryRepository>();
        }
    }
}
