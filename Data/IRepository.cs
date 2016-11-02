using System;
using System.Linq;
using System.Linq.Expressions;
using Domain.Entities;

namespace Data
{
    public interface IRepository<T> where T: class
    {
        T GetById(int id);
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter);
        IQueryable<T> GetAll();
        bool Save(T entity);
        bool Delete(int id);
        bool Delete(T entity);
    }
}
