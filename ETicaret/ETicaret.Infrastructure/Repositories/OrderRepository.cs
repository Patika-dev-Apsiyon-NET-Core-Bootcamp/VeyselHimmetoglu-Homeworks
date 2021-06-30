using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Domain.Interfaces;
using ETicaret.Domain.Models;
using ETicaret.Infrastructure.Context;

namespace ETicaret.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order> , IOrderRepository
    {
        public OrderRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}
