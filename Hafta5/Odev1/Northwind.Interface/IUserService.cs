using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface IUserService:IGenericService<User,DtoUser>
    {
        IResponse <DtoUserToken> Login(DtoLogin login);
        IResponse<DtoUser> Register(DtoUser user, bool saveChanges=true);
    }
}
