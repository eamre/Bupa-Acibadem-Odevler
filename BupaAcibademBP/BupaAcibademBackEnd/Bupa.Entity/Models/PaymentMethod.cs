using Bupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Bupa.Entity.Models
{
    public partial class PaymentMethod : EntityBase
    {
        public PaymentMethod()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Payment { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
