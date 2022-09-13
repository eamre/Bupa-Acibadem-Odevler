using Bupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Bupa.Entity.Models
{
    public partial class InstallmentOption : EntityBase
    {
        public InstallmentOption()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string InstallmentType { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
