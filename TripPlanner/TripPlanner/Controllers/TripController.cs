using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using TripPlanner.Services.Models;
using TripPlanner.Services.Services;
using TripPlanner.ViewModels;

namespace TripPlanner.Controllers
{
	public class TripController : Controller
	{
		private const int RecentTripsToDisplay = 5;
		private readonly TripService _tripService;

		public TripController(TripService tripService)
		{
			_tripService = tripService;
		}

		[HttpGet]
		public ActionResult New()
		{
			var newTripViewModel = new TripViewModel();

			return View(newTripViewModel);
		}

		[HttpPost]
		public ActionResult New(TripViewModel trip)
		{
			if (!ModelState.IsValid)
			{
				return View(trip);
			}

			var newTrip = _tripService.CreateNewTrip(Mapper.Map<Trip>(trip));

			return RedirectToAction("Browse", new {id = newTrip.Id});
		}

		[HttpGet]
		public ActionResult Browse(int id)
		{
			Trip trip = _tripService.GetById(id);

			if (trip == null)
			{
				return HttpNotFound();
			}

			var tripViewModel = Mapper.Map<DisplayTripViewModel>(trip);
			return View(tripViewModel);
		}

		[HttpGet]
		public ActionResult GetRecentTrips()
		{
			IEnumerable<Trip> recentTrips = _tripService.GetRecentTrips(RecentTripsToDisplay);
			var recentTripsToDisplay = Mapper.Map<IEnumerable<DisplayTripViewModel>>(recentTrips);

			return PartialView("RecentTrips", recentTripsToDisplay);
		}
	}
}