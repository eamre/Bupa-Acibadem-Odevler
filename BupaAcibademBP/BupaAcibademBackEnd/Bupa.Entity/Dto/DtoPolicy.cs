using Bupa.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Entity.Dto
{
    public class DtoPolicy : DtoBase
    {
        public DtoPolicy()
        {
        }
 
        public string PolicyName { get; set; }
        public int PolicyPrice { get; set; }
    }
}
