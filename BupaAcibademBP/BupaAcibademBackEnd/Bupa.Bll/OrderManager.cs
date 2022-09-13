using Bupa.Bll.Base;
using Bupa.Dal.Abstract;
using Bupa.Entity.Dto;
using Bupa.Entity.Models;
using Bupa.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Bll
{
    public class OrderManager : BllBase<Order, DtoOrder>, IOrderService
    {
        public readonly IOrderRepository orderRepository;

        public OrderManager(IServiceProvider service) : base(service)
        {
            orderRepository = service.GetService<IOrderRepository>();
        }

    }
}
