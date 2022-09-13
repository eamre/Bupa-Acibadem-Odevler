using Bupa.Entity.Dto;
using Bupa.Entity.IBase;
using Bupa.Entity.Models;
using Bupa.Interface;
using Bupa.WebApi.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bupa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ApiBaseController<ICustomerService, Customer, DtoCustomer>
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService) : base(customerService)
        {
            this.customerService = customerService;
        }

        //[HttpPost("Add")]
        //public IActionResult Add(DtoCustomer customer)
        //{
        //    try
        //    {
        //        return customerService.Register(user);
        //    }
        //    catch (Exception ex)
        //    {

        //        return new Response<DtoUser>
        //        {
        //            Message = $"Error:{ex.Message}",
        //            StatusCode = StatusCodes.Status500InternalServerError,
        //            Data = null
        //        };
        //    }
        //}

    }
}
