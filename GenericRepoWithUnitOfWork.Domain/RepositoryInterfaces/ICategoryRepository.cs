using GenericRepoWithUnitOfWork.Domain.Entities;

namespace GenericRepoWithUnitOfWork.Domain.RepositoryInterfaces
{
    public interface ICategoryRepository : IGenericRepository<ProductCategory>
    {
        List<ProductCategory> GetCategoryWithProduct();
    }
}
