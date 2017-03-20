using System.Web.Mvc;
using AutoMapper;
using TripPlanner.Services.Models;
using TripPlanner.Services.Services;
using TripPlanner.ViewModels;

namespace TripPlanner.Controllers
{
	public class TripController : Controller
	{
		private readonly TripService _tripService;

		public TripController(TripService tripService)
		{
			_tripService = tripService;
		}

		[HttpGet]
		public ActionResult New()
		{
			var newTripViewModel = new NewTripViewModel();

			return View(newTripViewModel);
		}

		[HttpPost]
		public ActionResult New(NewTripViewModel newTrip)
		{
			if (!ModelState.IsValid)
			{
				return View(newTrip);
			}

			_tripService.CreateNewTrip(Mapper.Map<Trip>(newTrip));

			return RedirectToAction("New");
		}
	}
}