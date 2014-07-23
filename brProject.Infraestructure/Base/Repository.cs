using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Util;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brProject.Infraestructure
{

    public class Repository<T> : IRepository<T> where T : class
    {
        #region IReadOnlyRepository<T> Members

        public IQueryable<T> All()
        {
            return FluentNHibernateHelper.Session.OpenSession().Query<T>();
        }

        public T FindBy(System.Linq.Expressions.Expression<System.Func<T, bool>> expression)
        {
            return FilterBy(expression).Single();
        }

        public IQueryable<T> FilterBy(System.Linq.Expressions.Expression<System.Func<T, bool>> expression)
        {
            return All().Where(expression).AsQueryable();
        }

        #endregion

        public IList<T> Get()
        {
            IList<T> list = null;

            using (ISession session = FluentNHibernateHelper.Session.OpenSession())
            {
                list = session.CreateCriteria<T>().List<T>();
            }

            return list;
        }

        public T Get(int Id)
        {
            T entity = null;

            using (ISession session = FluentNHibernateHelper.Session.OpenSession())
            {
                entity = session.Get<T>(Id);
            }

            return entity;
        }

        public int SaveOrUpdate(T entity)
        {
            int response = 0;

            using (ISession session = FluentNHibernateHelper.Session.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(entity);
                    transaction.Commit();
                }
            }

            return response;
        }

        public int Delete(T entity)
        {
            int response = 0;

            using (ISession session = FluentNHibernateHelper.Session.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(entity);
                    transaction.Commit();
                }
            }

            return response;
        }
    }


}
