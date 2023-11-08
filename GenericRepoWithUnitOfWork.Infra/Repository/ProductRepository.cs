using GenericRepoWithUnitOfWork.Domain.Entities;
using GenericRepoWithUnitOfWork.Domain.RepositoryInterfaces;
using GenericRepoWithUnitOfWork.Infra.DBContext;
using Microsoft.EntityFrameworkCore;

namespace GenericRepoWithUnitOfWork.Infra.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly EcommerceContext _context;
        public ProductRepository(EcommerceContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> GetProductWithCategory()
        {
            var results = _context.Products.Include(p => p.Category).ToList();
            return results;
        }
    }
}
