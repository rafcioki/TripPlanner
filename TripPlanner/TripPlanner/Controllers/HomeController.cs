﻿using System.Web.Mvc;
using TripPlanner.Services.Repositories;

namespace TripPlanner.Controllers
{
	public class HomeController : Controller
	{
		public HomeController()
		{
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