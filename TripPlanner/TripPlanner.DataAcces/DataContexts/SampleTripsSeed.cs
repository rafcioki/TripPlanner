using System;
using TripPlanner.Services.Models;

namespace TripPlanner.DataAcces.DataContexts
{
	public static class SampleTripsSeed
	{
		public static void Seed(TripPlannerDataContext context)
		{
			for (int i = 0; i < 4; ++i)
			{
				context.Trips.Add(new Trip
				{
					Created = DateTime.Now,
					Name = "Trip no " + i
				});
			}

			context.SaveChanges();
		}
	}
}
