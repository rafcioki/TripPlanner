using AutoMapper;
using TripPlanner.Services.Models;
using TripPlanner.ViewModels;

namespace TripPlanner.Mapping
{
	public class AutoMapperConfig
	{
		public static void Configure()
		{
			Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<TripViewModel, Trip>();
				cfg.CreateMap<Trip, DisplayTripViewModel>();
			});
		}
	}
}