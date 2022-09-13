using Bupa.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Entity.Dto
{
    public class DtoCustomer : DtoBase
    {
        public DtoCustomer()
        {
        }
        public int CustomerId { get; set; }
        public string CustomerIdentity { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthofDate { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        //public int InsurerId { get; set; }
    }
}
