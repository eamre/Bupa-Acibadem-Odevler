using Bupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Bupa.Entity.Models
{
    public partial class Customer : EntityBase
    {
        public Customer()
        {
            Cards = new HashSet<Card>();
            OrderDetails = new HashSet<OrderDetail>();
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string CustomerIdentity { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthofDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int? InsurerId { get; set; }

        public virtual PolicyOwner Insurer { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
