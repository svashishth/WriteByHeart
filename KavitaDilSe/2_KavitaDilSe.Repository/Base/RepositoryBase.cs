using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2_KavitaDilSe.Repository.Base
{
    public class RepositoryBase : IRepositoryBase
    {
        protected IKavitaDilSeDbContext _dbContext;

        public RepositoryBase()
        {
            _dbContext = new KavitaDilSeDbContext();
        }

        protected IKavitaDilSeDbContext DatabaseContext
        {
            get
            {
                if (null == _dbContext)
                    throw new ArgumentNullException("DBContext cannot be null!");

                return _dbContext;
            }
        }

        public virtual IQueryable<TEntity> GetAll<TEntity>() where TEntity : class
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();
            return query;
        }

        public virtual IQueryable<TEntity> GetBy<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>().Where(predicate);
            return query;
        }

        public virtual void Add<TEntity>(TEntity objModel) where TEntity : class
        {
            _dbContext.Set<TEntity>().Add(objModel);
        }

        public virtual void Update<TEntity>(TEntity objModel) where TEntity : class
        {
            _dbContext.Entry<TEntity>(objModel).State = EntityState.Modified;
        }

        public virtual void Delete<TEntity>(TEntity objModel) where TEntity : class
        {
            _dbContext.Entry<TEntity>(objModel).State = EntityState.Deleted;
        }

        public virtual void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool isDisposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing && null != _dbContext)
                {
                    _dbContext.Dispose();
                    //add the instance to be disposed 
                }
                //set the instance to null
                _dbContext = null;
                isDisposed = true;
            }
        }
    }
}
