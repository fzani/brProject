using brProject.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brProject.Infraestructure
{

    public class FluentNHibernateHelper
    {
        private static ISessionFactory _session;
        public static ISessionFactory Session
        {
            get
            {
                if (_session == null)
                    InitializeSessionFactory();

                return _session;
            }
        }

        private static void InitializeSessionFactory()
        {
            _session = Fluently.Configure()
                                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c.FromConnectionStringWithKey("DefaultConnection")).ShowSql())
                                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<StoreMap>())
                                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, false))
                                .BuildSessionFactory();
        }
    }

}
