using System.Data.Entity;
using TripPlanner.Services.Models;

namespace TripPlanner.DataAcces.DataContexts
{
	public class TripPlannerDataContext : DbContext
	{
		public TripPlannerDataContext() : base("TripPlannerContext")
		{
		}

		public DbSet<Trip> Trips { get; set; }

		public static TripPlannerDataContext Create()
		{
			return new TripPlannerDataContext();
		}
	}
}
