using ArtWebshop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArtWebshop.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected ProductDbContext _productContext;
        
        public Repository(ProductDbContext productDbContext)
        {
            _productContext = productDbContext;

        }
        public virtual T Add(T entity)
        {
            return _productContext.Add(entity).Entity;
        }

        public virtual IEnumerable<T> All()
        {
            return _productContext.Set<T>().ToList();
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _productContext.Set<T>().AsQueryable().Where(predicate).ToList();
        }

        public virtual T Get(string id)
        {
            return _productContext.Find<T>(id);
        }

        public virtual void SaveChanges()
        {
            _productContext.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            return _productContext.Update(entity).Entity;
        }
    }
}
