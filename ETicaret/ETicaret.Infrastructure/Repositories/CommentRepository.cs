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
    public class CommentRepository :  Repository<Comment> , ICommentRepository
    {
        public CommentRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}
