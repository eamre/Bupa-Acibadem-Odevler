using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Models
{
    public class User:EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage ="User ID zorunlu")]
        public int UserID { get; set; }

        [MaxLength(30)]
        public string UserName { get; set; }

        [MaxLength(30)]
        public string UserLastName { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "UserCode zorunlu")]
        public string UserCode { get; set; }

        [MaxLength(60)]
        [Required(ErrorMessage = "Password zorunlu")]
        public string Password { get; set; }
    }
}
