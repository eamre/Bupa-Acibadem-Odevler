using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll.Base
{
    public class TokenManager
    {
        IConfiguration configuration;//appsettingteki token key e erişmek için

        public TokenManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //Token üretilecek metod
        public string CreateAccessToken(DtoLoginUser user)
        {
            //claims oluşturmak //bazı bilgileri token a gömebilmek için oluşturuyorz
            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Sub, user.UserCode),
                 new Claim(JwtRegisteredClaimNames.Jti, user.UserID.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Token");

            //claims roller
            var claimsRoleList = new List<Claim>
            {
                new Claim("role", "Admin"),
                //new Claim("role2","")
            };

            //security key'in simetreiğini alıyoruz
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Tokens:Key"]));

            //şifrelenmiş kimlik oluşturuyoruz
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //token ayarlarını yapıyoruz
            var token = new JwtSecurityToken
                (
                 issuer: configuration["Tokens:Issuer"],//token dağıtıcı url
                 audience: configuration["Tokens:Issuer"],//erişilebilecek api'ler
                 expires: DateTime.Now.AddMinutes(5),//token süresini 5 dk. ayarladık, ömrünü 5 dk.
                 notBefore: DateTime.Now, //token üretildikten sonra ne kdar süre sonra devreye gireceğini ayarlıyoruz.
                 signingCredentials: cred,//kimliği verdik
                 claims: claimsIdentity.Claims//claimsleri verdik
                );

            //token oluşturmak sınıfı ile bir örnek alıp token üretiyoruz

            var tokenHandler = new { token = new JwtSecurityTokenHandler().WriteToken(token) };

            return tokenHandler.token;
        }
    }

}
