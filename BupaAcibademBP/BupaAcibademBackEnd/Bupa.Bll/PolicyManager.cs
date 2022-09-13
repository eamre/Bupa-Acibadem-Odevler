using Bupa.Bll.Base;
using Bupa.Dal.Abstract;
using Bupa.Entity.Dto;
using Bupa.Entity.Models;
using Bupa.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Bupa.Bll
{
    public class PolicyManager : BllBase<Policy, DtoPolicy>, IPolicyService
    {
        public readonly IPolicyRepository policyRepository;

        public PolicyManager(IServiceProvider service) : base(service)
        {
             policyRepository = service.GetService<IPolicyRepository>();
        }

    }
}
