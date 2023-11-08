using GenericRepoWithUnitOfWork.Domain.Entities;

namespace GenericRepoWithUnitOfWork.Domain.RepositoryInterfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetProductWithCategory();
    }
}
