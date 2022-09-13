using Bupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Bupa.Entity.Models
{
    public partial class PolicyOwner : EntityBase
    {
        public PolicyOwner()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string InsurerIdentity { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime? Birthdate { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
