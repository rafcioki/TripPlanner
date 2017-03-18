using System.Collections.Generic;
using TripPlanner.Services.Models;

namespace TripPlanner.Services.Repositories
{
	public interface ITripRepository
	{
		void SaveTrip(Trip newTrip);
	}
}
