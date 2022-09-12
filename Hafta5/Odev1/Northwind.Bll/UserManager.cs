using Microsoft.Extensions.Configuration;
using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Entity.Base;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;

namespace Northwind.Bll
{
    public class UserManager : BllBase<User, DtoUser>, IUserService
    {
        public readonly IUserRepository userRepository;
        IConfiguration configuration;
        MD5Crypt md5 = new MD5Crypt();

        public UserManager(IServiceProvider service, IConfiguration configuration) : base(service)
        {
            userRepository = service.GetService<IUserRepository>();//user repository geliyor - Iuserrepo olduğunda userrepository den türet onu new user repository getiriyor
            this.configuration = configuration;
            
        }
        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            var user = userRepository.Login(ObjectMapper.Mapper.Map<User>(login));//gelen dto logini user login e çevirdi

            if (user != null)
            {
                var dtoUser = ObjectMapper.Mapper.Map<DtoLoginUser>(user);
                var token = new TokenManager(configuration).CreateAccessToken(dtoUser);

                var userToken = new DtoUserToken()
                {
                    DtoLoginUser = dtoUser,
                    AccessToken = token
                };

                return new Response<DtoUserToken>()
                {
                    Message = "Token is success!",
                    StatusCode = StatusCodes.Status200OK,
                    Data = userToken
                };
            }
            else
            {
                return new Response<DtoUserToken>()
                {
                    Message = "UserCode or Password is wrong",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }
        public IResponse<DtoUser> Register(DtoUser user,bool saveChanges=true)
        {
            //var userReg=userRepository.Login(ObjectMapper.Mapper.Map<User>(user));//var dtoUser = ObjectMapper.Mapper.Map<DtoUser>(userReg);
            try
            {
                var resolvedResult = "";

                var passwordCrypt = md5.MD5Hash(user.Password);

                var userRegister = new DtoUser
                {
                    UserCode = user.UserCode,
                    UserName = user.UserName,
                    UserLastName = user.UserLastName,
                    Password = passwordCrypt
                };

                var TResult = userRepository.Register(ObjectMapper.Mapper.Map<User>(userRegister));
                resolvedResult = String.Join(',', TResult.GetType().GetProperties().Select(x => $" - {x.Name} : {x.GetValue(TResult) ?? ""} - "));

                if (saveChanges)
                {
                    Save();
                }

                return new Response<DtoUser>()
                {
                    Message = "Kayıt Başarılı",
                    StatusCode = StatusCodes.Status200OK,
                    Data = ObjectMapper.Mapper.Map<User, DtoUser>(TResult)
                };
            }
            catch (Exception)
            {
                return new Response<DtoUser>
                {
                    Message = "KayıtOlmadı",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }
    }
}
