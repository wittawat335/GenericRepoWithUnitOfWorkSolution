using GenericRepoWithUnitOfWork.Domain.RepositoryInterfaces;
using GenericRepoWithUnitOfWork.Infra.DBContext;
using System;
using System.Linq.Expressions;

namespace GenericRepoWithUnitOfWork.Infra.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly EcommerceContext _context;

        public GenericRepository(EcommerceContext context)
        {
            _context = context;
        }

        public List<T> GetAll() => _context.Set<T>().ToList();

        public T GetById(int id) => _context.Set<T>().Find(id);

        public List<T> Find(Expression<Func<T, bool>> predicate) => _context.Set<T>().Where(predicate).ToList();

        public void Add(T entity) => _context.Set<T>().Add(entity);

        public void Update(T entity) => _context.Update(entity);

        public void Delete(T entity) => _context.Remove(entity);
    }
}
