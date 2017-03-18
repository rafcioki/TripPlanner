using System.Web.Mvc;
using TripPlanner.Services.Repositories;

namespace TripPlanner.Controllers
{
	public class HomeController : Controller
	{
		private readonly ITripRepository _tripRepository;

		public HomeController(ITripRepository tripRepository)
		{
			_tripRepository = tripRepository;
		}

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}