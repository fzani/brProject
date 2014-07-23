using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace brProject.Infraestructure
{

    public interface IRepository<T> : IReadOnlyRepository<T> where T : class
    {
        IList<T> Get();
        T Get(int Id);
        int SaveOrUpdate(T Entity);
        int Delete(T entity);
    }

    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> All();
        TEntity FindBy(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> FilterBy(Expression<Func<TEntity, bool>> expression);
    }
}
