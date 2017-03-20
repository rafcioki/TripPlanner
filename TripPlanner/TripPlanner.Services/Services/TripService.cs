using TripPlanner.Services.Models;
using TripPlanner.Services.Repositories;

namespace TripPlanner.Services.Services
{
	public class TripService
	{
		private readonly ITripRepository _tripRepository;

		public TripService(ITripRepository tripRepository)
		{
			_tripRepository = tripRepository;
		}

		public void CreateNewTrip(Trip newTrip)
		{
			_tripRepository.SaveTrip(newTrip);
		}
	}
}
