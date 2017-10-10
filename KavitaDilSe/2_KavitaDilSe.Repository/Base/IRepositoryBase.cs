using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2_KavitaDilSe.Repository.Base
{
    public interface IRepositoryBase : IDisposable
    {
        IQueryable<TEntity> GetAll<TEntity>() where TEntity : class;

        IQueryable<TEntity> GetBy<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;

        void Add<TEntity>(TEntity objModel) where TEntity : class;

        void Update<TEntity>(TEntity objModel) where TEntity : class;

        void Delete<TEntity>(TEntity objModel) where TEntity : class;

        void Save();
    }
}
