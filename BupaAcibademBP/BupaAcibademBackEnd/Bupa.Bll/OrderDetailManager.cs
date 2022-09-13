using Bupa.Bll.Base;
using Bupa.Dal.Abstract;
using Bupa.Entity.Dto;
using Bupa.Entity.Models;
using Bupa.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Bll
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
