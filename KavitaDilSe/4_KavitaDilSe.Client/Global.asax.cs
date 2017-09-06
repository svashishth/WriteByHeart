using _2_KavitaDilSe.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace _4_KavitaDilSe.Client
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            UnityConfig.RegisterComponents();

            //register automapper
            //AutoMapperConfig.RegisterMappings();

            //run the seed method to initialize the master table data
            Database.SetInitializer(new CustomDatabaseInitializer());
            var dbContext = new KavitaDilSeDbContext();
            dbContext.Database.Initialize(force: true);

        }
    }
}
