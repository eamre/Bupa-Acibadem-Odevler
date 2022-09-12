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
    public class OrderDetailManager : BllBase<OrderDetail, DtoOrderDetail>, IOrderDetailService
    {
        public readonly IOrderDetailRepository orderDetailRepository;

        public OrderDetailManager(IServiceProvider service) : base(service)
        {
            orderDetailRepository = service.GetService<IOrderDetailRepository>();
        }
    
    }
}
