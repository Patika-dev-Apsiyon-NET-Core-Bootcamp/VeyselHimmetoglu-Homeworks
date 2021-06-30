using ETicaret.Domain.Interfaces;
using ETicaret.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Infrastructure
{
    public class UnitofWork : IUnitofWork
    {
        public IBasketRepository Basket { get; }
        public ICategoryRepository  Category { get; }
        public ICommentRepository Comment { get; }
        public IFavoriteRepository Favorite { get; }
        public IOrderRepository Order { get; }

        private readonly ETicaretDbContext _context;

        public UnitofWork(ETicaretDbContext context, IBasketRepository basketRepository, ICategoryRepository category, ICommentRepository comment, IFavoriteRepository favorite, IOrderRepository order)
        {
            _context = context;
            Basket = basketRepository;
            Category = category;
            Comment = comment;
            Favorite = favorite;
            Order = order;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
