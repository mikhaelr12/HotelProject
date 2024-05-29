using System;
using System.Linq;
using System.Web.Mvc;
using Hotel.BusinessLogic.Interfaces;
using Hotel.Domain.Entities.User;
using Hotel.Domain.Enums;
using Hotel.Web.Models;

namespace Hotel.Web.Controllers
{
	public class CancelBookingController : BaseController 
	{
		private readonly ISession _session;

		public CancelBookingController()
		{
			var bl = new BusinessLogic.BusinessLogic();
			_session = bl.GetSessionBL();
		}

		// GET: CancelBooking
		[HttpGet]
		public ActionResult Index()
		{
			
			var loggedInUser = GetLoggedInUserFromCookie();

			var usersBooking = _session.GetUsersBookings(loggedInUser.Username);
			var mappedBookings = usersBooking.Select(b => new UserBooking
			{
				CheckIn = b.CheckInDate,
				CheckOut = b.CheckOutDate,
				RoomType = b.Room.RoomType,
				FinalPrice = b.FinalPrice
			});

			return View(mappedBookings);
		}

		public ActionResult CancelBooking(DateTime checkInDate, RoomType roomType)
		{
			_session.CancelBooking(checkInDate,roomType);

			return RedirectToAction("Index");

		}

		private UserMinimal GetLoggedInUserFromCookie()
		{
			var apiCookie = Request.Cookies["X-KEY"];
			if (apiCookie != null)
			{
				var profile = _session.GetUserByCookie(apiCookie.Value);
				return profile;
			}
			return null;
		}
	}
}
