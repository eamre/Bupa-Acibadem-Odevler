using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class OrderRepository : GenericRepository<Order>,IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context)
        {
        }

        public IQueryable OrderReport(int orderId)
        {
            //return dbset.AsQueryable();
            var t = dbset.Where(x => x.OrderId == 10262).SingleOrDefault();
            var y = t.OrderDetails;
            return null;
        }
    }
}
