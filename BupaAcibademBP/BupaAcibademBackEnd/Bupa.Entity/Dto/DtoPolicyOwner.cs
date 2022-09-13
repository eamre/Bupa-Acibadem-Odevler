using Bupa.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Entity.Dto
{
    public class DtoPolicyOwner : DtoBase
    {
        public DtoPolicyOwner()
        {
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
    }
}
