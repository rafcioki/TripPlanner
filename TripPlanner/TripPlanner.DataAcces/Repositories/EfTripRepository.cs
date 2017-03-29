using System.Collections.Generic;
using System.Linq;
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

		public Trip SaveTrip(Trip newTrip)
		{
			_tripPlannerDataContext.Trips.Add(newTrip);

			_tripPlannerDataContext.SaveChanges();

			return newTrip;
		}

		public Trip GetById(int id)
		{
			return _tripPlannerDataContext.Trips.SingleOrDefault(trip => trip.Id == id);
		}

		public IEnumerable<Trip> GetRecentTrips(int howMany)
		{
			return _tripPlannerDataContext.Trips.OrderByDescending(trip => trip.Created).Take(howMany);
		}
	}
}
