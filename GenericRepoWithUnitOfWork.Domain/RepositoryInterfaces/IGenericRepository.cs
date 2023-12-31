﻿
using System.Linq.Expressions;

namespace GenericRepoWithUnitOfWork.Domain.RepositoryInterfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        List<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
