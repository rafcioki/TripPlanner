using System.Data.Entity;
using TripPlanner.DataAcces.DataContexts;

namespace TripPlanner.DataAcces.DbSetup
{
	public class TripsDbInitializer : CreateDatabaseIfNotExists<TripPlannerDataContext>
	{
		protected override void Seed(TripPlannerDataContext context)
		{
			SampleTripsSeed.Seed(context);
		}
	}
}
