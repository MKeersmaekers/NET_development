using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvcMovie.Data;
using System.Linq.Expressions;

namespace MvcMovie.DAL
{
    public class GenericRepository<T> :
        IRepository<T> where T : class
    {
        private MovieContext _context;
        private DbSet<T> _dbSet = null;
        public GenericRepository(MovieContext context)
        {
            _context = context;
            _dbSet= _context.Set<T>();
        }
        public void Delete(int id)
        {
            T obj = _dbSet.Find(id);
            _dbSet.Remove(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetByID(int id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(T obj)
        {
            _dbSet.Add(obj);
        }

        //public void Save()
        //{
        //    _context.SaveChanges();
        //}

        public void Update(T obj)
        {
            _dbSet.Update(obj);
        }

        public IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbSet;
            foreach (Expression<Func<T, object>> include in includes)
                query = query.Include(include);
            if (filter != null)
                query = query.Where(filter);
            if (orderBy != null)
                query = orderBy(query);
            return query.ToList();
        }
    }
}
