namespace GenericRepoWithUnitOfWork.Domain.RepositoryInterfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        int SaveChanges();
    }
}
