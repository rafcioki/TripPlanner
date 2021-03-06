﻿using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SimpleInjector.Integration.Web.Mvc;
using TripPlanner.CompositionRoot;
using TripPlanner.DataAcces.DbSetup;
using TripPlanner.Mapping;

namespace TripPlanner
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

	        var container = DependencyInjectionConfig.CreateAndConfigureSimpleInjector();
			DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
			AutoMapperConfig.Configure();
			Database.SetInitializer(new TripsDbInitializer());
        }
    }
}
