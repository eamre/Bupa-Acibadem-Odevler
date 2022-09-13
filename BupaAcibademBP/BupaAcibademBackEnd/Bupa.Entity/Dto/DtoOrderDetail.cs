using Bupa.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Entity.Dto
{
    public class DtoOrderDetail : DtoBase
    {
        public DtoOrderDetail()
        {
        }
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? CardId { get; set; }
        public int? InstallmentType { get; set; }
        public int? PaymentType { get; set; }
        public int? OrderId { get; set; }
        public int? PolicyId { get; set; }
    }
}
