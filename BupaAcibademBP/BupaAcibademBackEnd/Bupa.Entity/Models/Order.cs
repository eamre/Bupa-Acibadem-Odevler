using Bupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Bupa.Entity.Models
{
    public partial class Order : EntityBase
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? PolicyId { get; set; }
        public DateTime OrderDate { get; set; }
        public int? OrderStatus { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
