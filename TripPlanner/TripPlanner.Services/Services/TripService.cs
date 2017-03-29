using System;
using System.Collections.Generic;
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

		public Trip CreateNewTrip(Trip newTrip)
		{
			newTrip.Created = DateTime.Now;
			return _tripRepository.SaveTrip(newTrip);
		}

		public Trip GetById(int id)
		{
			return _tripRepository.GetById(id);
		}

		public IEnumerable<Trip> GetRecentTrips(int howMany)
		{
			return _tripRepository.GetRecentTrips(howMany);
		}
	}
}
