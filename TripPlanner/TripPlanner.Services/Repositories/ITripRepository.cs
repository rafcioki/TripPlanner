using System.Collections.Generic;
using TripPlanner.Services.Models;

namespace TripPlanner.Services.Repositories
{
	public interface ITripRepository
	{
		Trip SaveTrip(Trip newTrip);
		Trip GetById(int id);
		IEnumerable<Trip> GetRecentTrips(int howMany);
	}
}
