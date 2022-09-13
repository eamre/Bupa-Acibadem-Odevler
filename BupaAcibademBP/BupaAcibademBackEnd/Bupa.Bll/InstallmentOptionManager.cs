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
    public class InstallmentOptionManager : BllBase<InstallmentOption, DtoInstallmentOption>, IInstallmentOptionService
    {
        public readonly IInstallmentOptionRepository installmentOptionRepository;

        public InstallmentOptionManager(IServiceProvider service) : base(service)
        {
            installmentOptionRepository = service.GetService<IInstallmentOptionRepository>();
        }

    }
}
