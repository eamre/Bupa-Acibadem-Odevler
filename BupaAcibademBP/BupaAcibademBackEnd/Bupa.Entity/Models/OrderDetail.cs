using Bupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Bupa.Entity.Models
{
    public partial class OrderDetail : EntityBase
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? CardId { get; set; }
        public int? InstallmentType { get; set; }
        public int? PaymentType { get; set; }
        public int? OrderId { get; set; }
        public int? PolicyId { get; set; }

        public virtual Card Card { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual InstallmentOption InstallmentTypeNavigation { get; set; }
        public virtual Order Order { get; set; }
        public virtual PaymentMethod PaymentTypeNavigation { get; set; }
        public virtual Policy Policy { get; set; }
    }
}
