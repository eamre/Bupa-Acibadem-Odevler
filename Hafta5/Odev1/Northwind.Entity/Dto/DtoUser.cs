using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
    public class DtoUser:DtoBase
    {
        [JsonIgnore]
        public int UserID { get; set; }

        public string UserName { get; set; }
     
        public string UserLastName { get; set; }
  
        public string UserCode { get; set; }
        //[JsonIgnore]
        public string Password { get; set; }
    }
}
