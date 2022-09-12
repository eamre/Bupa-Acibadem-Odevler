using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[AllowAnonymous]
    public class CustomerController : ApiBaseController<ICustomerService, Customer, DtoCustomer>
    {
        private readonly ICustomerService service;
        public CustomerController(ICustomerService service) : base(service)
        {
            this.service = service;
        }

        [HttpGet("StringId")]
        //[AllowAnonymous]
        public IResponse<DtoCustomer> CustomerFind(string id)
        {
            try
            {
                var centity = service.FindCustomer(id);
                return centity;
            }
            catch (Exception ex)
            {
                return new Response<DtoCustomer>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }
    }
}
