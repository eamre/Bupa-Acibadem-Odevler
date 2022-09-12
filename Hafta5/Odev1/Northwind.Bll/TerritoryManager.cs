using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class TerritoryManager : BllBase<Territory, DtoTerritory>, ITerritoryService
    {
        public readonly ITerritoryRepository territoryRepository;

        public TerritoryManager(IServiceProvider service) : base(service)
        {
            territoryRepository = service.GetService<ITerritoryRepository>();
        }
    
    }
}
