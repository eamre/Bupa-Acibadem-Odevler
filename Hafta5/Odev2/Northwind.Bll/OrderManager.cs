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

namespace Northwind.Bll
{
    public class OrderManager : BllBase<Order, DtoOrder>, IOrderService
    {
        public readonly IOrderRepository orderRepository;

        public OrderManager(IServiceProvider service):base(service)
        {
            orderRepository = service.GetService<IOrderRepository>();
        }

        public IQueryable OrderReport(int orderId)
        {
           return orderRepository.OrderReport(orderId);
        }
    }
}
