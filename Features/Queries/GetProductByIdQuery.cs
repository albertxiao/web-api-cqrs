using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApiCQRS.Context;
using WebApiCQRS.Models;

namespace WebApiCQRS.Features.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }

        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
        {

            private readonly IApplicationContext _context;
            public GetProductByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Product> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
            {
                var existingProduct = _context.Products.Where(x => x.Id == query.Id).FirstOrDefaultAsync(cancellationToken);
                
                var result = existingProduct == null ? null : await existingProduct;
                
                return result;
            }
        }
    }
}
