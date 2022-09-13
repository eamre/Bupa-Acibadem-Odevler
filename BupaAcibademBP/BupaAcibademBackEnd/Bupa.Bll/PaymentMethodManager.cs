using Bupa.Bll.Base;
using Bupa.Dal.Abstract;
using Bupa.Entity.Dto;
using Bupa.Entity.Models;
using Bupa.Interface;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Bll
{
    public class PaymentMethodManager : BllBase<PaymentMethod, DtoPaymentMethod>, IPaymentMethodService
    {
        public readonly IPaymentMethodRepository paymentMethodRepository;

        public PaymentMethodManager(IServiceProvider service) : base(service)
        {
            paymentMethodRepository = service.GetService<IPaymentMethodRepository>();
        }

    }
}
