using GenericRepoWithUnitOfWork.Domain.RepositoryInterfaces;
using GenericRepoWithUnitOfWork.Infra.DBContext;

namespace GenericRepoWithUnitOfWork.Infra.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EcommerceContext _context;

        public UnitOfWork(EcommerceContext context)
        {
            _context = context;
            Product = new ProductRepository(context);
            Category = new CategoryRepository(context);//
        }

        public IProductRepository Product { get; private set; }
        public ICategoryRepository Category { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
