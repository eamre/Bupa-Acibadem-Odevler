using Bupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Bupa.Entity.Models
{
    public partial class Policy : EntityBase
    {
        public Policy()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string PolicyName { get; set; }
        public int PolicyPrice { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
