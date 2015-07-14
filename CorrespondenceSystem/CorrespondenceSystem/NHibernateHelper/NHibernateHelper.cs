using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*librerias NHibernate*/
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Automapping;

using System.Reflection;

namespace MvcGCP.NHibernateHelpers
{
    public class NHibernateHelper
    {
        private readonly string _connectionString;
        private ISessionFactory _sessionFactory;
        
        public ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = CreateSessionFactory()); }
        }

        public NHibernateHelper()
        {
            // _connectionString = @"Data Source=CODE-PC\DANTESQL;Initial Catalog=GCP;Trusted_Connection=True";

            //  _connectionString = @"Data Source=DES-06-PC\MSSQLSERVER02;Initial Catalog=GCP;Trusted_Connection=True";

            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LocalWork"].ToString();

            //@"Data Source=SOL-DS-01;Initial Catalog=GCP;Trusted_Connection=True";
        }

        public ISessionFactory CreateSessionFactory()
        {
            var configuration = Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2008
                .ConnectionString(_connectionString)
                .ShowSql())
            .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
            .BuildConfiguration();

             var exporter = new SchemaExport(configuration);
            exporter.Drop(false,false);
            exporter.Execute(false,true,false);
            _sessionFactory = configuration.BuildSessionFactory();
            return _sessionFactory;
        }

       // protected virtual void configuracion(Configuration conf)
       // {
       //     var exporter = new SchemaExport(conf);
       //     exporter.Drop(false, true);
       //     var update = new SchemaUpdate(conf);
       //     update.Execute(false, true);
       // }
    }
}