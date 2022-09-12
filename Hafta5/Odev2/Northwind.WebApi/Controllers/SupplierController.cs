using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
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
    public class SupplierController : ApiBaseController<ISupplierService, Supplier, DtoSupplier>
    {
        private readonly ISupplierService supplierService;

        public SupplierController(ISupplierService supplierService) : base(supplierService)
        {
            this.supplierService = supplierService;
        }

    }
}
