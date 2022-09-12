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
    public class ShipperManager : BllBase<Shipper, DtoShipper>, IShipperService
    {
        public readonly IShipperRepository shipperRepository;

        public ShipperManager(IServiceProvider service) : base(service)
        {
            shipperRepository = service.GetService<IShipperRepository>();
        }
    
    }
}
