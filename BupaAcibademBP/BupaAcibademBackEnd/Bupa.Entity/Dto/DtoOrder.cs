using Bupa.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Entity.Dto
{
    public class DtoOrder : DtoBase
    {
        public DtoOrder()
        {
        }
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? PolicyId { get; set; }
        public DateTime OrderDate { get; set; }
        public int? OrderStatus { get; set; }
    }
}
