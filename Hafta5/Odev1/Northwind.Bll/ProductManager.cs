using Northwind.Bll.Base;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class ProductManager : BllBase<Product, DtoProduct>, IProductService
    {
        public readonly IProductRepository productRepository;

        public ProductManager(IServiceProvider service) : base(service)
        {
            productRepository = service.GetService<IProductRepository>();
        }
    
    }
}
