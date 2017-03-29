using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TripPlanner.ViewModels
{
	public class TripViewModel
	{
		[DisplayName("Trip name:")]
		[Required(ErrorMessage = "Please enter the trip name.")]
		public string Name { get; set; }
	}
}