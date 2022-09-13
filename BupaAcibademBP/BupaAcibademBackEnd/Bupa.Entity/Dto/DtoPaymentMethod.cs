using Bupa.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Entity.Dto
{
    public class DtoPaymentMethod : DtoBase
    {
        public DtoPaymentMethod()
        {
        }
        public int Id { get; set; }
        public string Payment { get; set; }
    }
}
