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
    public class CardManager : BllBase<Card, DtoCard>, ICardService
    {
        public readonly ICardRepository cardRepository;

        public CardManager(IServiceProvider service) : base(service)
        {
            cardRepository = service.GetService<ICardRepository>();
        }

    }
}
