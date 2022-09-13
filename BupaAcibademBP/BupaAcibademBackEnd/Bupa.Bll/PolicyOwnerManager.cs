using Bupa.Bll.Base;
using Bupa.Dal.Abstract;
using Bupa.Entity.Dto;
using Bupa.Entity.Models;
using Microsoft.Extensions.DependencyInjection;
using Bupa.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Bll
{
    public class PolicyOwnerManager : BllBase<PolicyOwner, DtoPolicyOwner>, IPolicyOwnerService
    {
        public readonly IPolicyOwnerRepository policyOwnerRepository;

        public PolicyOwnerManager(IServiceProvider service) : base(service)
        {
            policyOwnerRepository = service.GetService<IPolicyOwnerRepository>();
        }

    }
}
