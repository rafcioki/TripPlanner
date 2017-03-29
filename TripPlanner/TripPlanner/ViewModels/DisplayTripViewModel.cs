using System;
using System.ComponentModel;

namespace TripPlanner.ViewModels
{
	public class DisplayTripViewModel
	{
		public int Id { get; set; }
		[DisplayName("Trip name:")]
		public string Name { get; set; }
		public DateTime Created { get; set; }
	}
}