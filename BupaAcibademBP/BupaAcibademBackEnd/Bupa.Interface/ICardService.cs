using Bupa.Entity.Dto;
using Bupa.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Interface
{
    public interface ICardService : IGenericService<Card, DtoCard>
    {
    }
}
