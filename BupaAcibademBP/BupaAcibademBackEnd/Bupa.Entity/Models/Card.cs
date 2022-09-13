using Bupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Bupa.Entity.Models
{
    public partial class Card : EntityBase
    {
        public Card()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string CardHolderFullName { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpDate { get; set; }
        public string Cvccode { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
