using Bupa.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Entity.Dto
{
    public class DtoCard : DtoBase
    {
        public DtoCard()
        {
        }
        public int Id { get; set; }

      //  public int? CustomerId { get; set; }
        public string CardHolderFullName { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpDate { get; set; }
        public string Cvccode { get; set; }
    }
}
