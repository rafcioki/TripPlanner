using System.Reflection;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using TripPlanner.DataAcces.DataContexts;
using TripPlanner.DataAcces.Repositories;
using TripPlanner.Services.Repositories;

namespace TripPlanner.CompositionRoot
{
	public class DependencyInjectionConfig
	{
		public static Container CreateAndConfigureSimpleInjector()
		{
			var container = new Container();
			container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

			ConfigureDataContexts(container);
			ConfigureRepositories(container);
			ConfigureServices(container);

			container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

			container.Verify();

			return container;
		}

		private static void ConfigureDataContexts(Container container)
		{
			container.Register<TripPlannerDataContext>(Lifestyle.Scoped);
		}

		private static void ConfigureRepositories(Container container)
		{
			container.Register<ITripRepository, EfTripRepository>();
		}

		private static void ConfigureServices(Container container)
		{
		}
	}
}