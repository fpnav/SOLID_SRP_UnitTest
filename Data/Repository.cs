using System;
using System.Linq;
using System.Linq.Expressions;


namespace Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Context _context;
        public Repository()
        {
            _context = new Context();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
