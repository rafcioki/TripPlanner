using TripPlanner.DataAcces.DataContexts;
using TripPlanner.Services.Models;
using TripPlanner.Services.Repositories;

namespace TripPlanner.DataAcces.Repositories
{
	public class EfTripRepository : ITripRepository
	{
		private readonly TripPlannerDataContext _tripPlannerDataContext;

		public EfTripRepository(TripPlannerDataContext tripPlannerDataContext)
		{
			_tripPlannerDataContext = tripPlannerDataContext;
		}

		public void SaveTrip(Trip newTrip)
		{
			_tripPlannerDataContext.Trips.Add(newTrip);

			_tripPlannerDataContext.SaveChanges();
		}
	}
}
