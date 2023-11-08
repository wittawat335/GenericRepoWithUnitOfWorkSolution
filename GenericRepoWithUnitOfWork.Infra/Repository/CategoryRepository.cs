using GenericRepoWithUnitOfWork.Domain.Entities;
using GenericRepoWithUnitOfWork.Domain.RepositoryInterfaces;
using GenericRepoWithUnitOfWork.Infra.DBContext;
using Microsoft.EntityFrameworkCore;

namespace GenericRepoWithUnitOfWork.Infra.Repository
{
    public class CategoryRepository : GenericRepository<ProductCategory>, ICategoryRepository
    {
        private readonly EcommerceContext _context;

        public CategoryRepository(EcommerceContext context) : base(context)
        {
            _context = context;
        }

        public List<ProductCategory> GetCategoryWithProduct()
        {
            var results = _context.ProductCategories.Include(p => p.Products).ToList();
            return results;
        }
    }
}
