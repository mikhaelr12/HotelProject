using Hotel.Web.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Tree;
using AutoMapper;
using Hotel.Domain.Entities.User;
using Hotel.Web.Models;
using Hotel.BusinessLogic.Interfaces;

namespace Hotel.Web.Controllers
{

    public class ReservationController : BaseController
    {
	private readonly ISession _session;

	public ReservationController()
	{
		var bl = new BusinessLogic.BusinessLogic();
		_session = bl.GetSessionBL();
	}

		// GET: Reservation
		public ActionResult Index()
		{
			if (!IsUserLoggedIn())
			{
				return RedirectToAction("Index", "Login");
			}
			return View();
		}

		private bool IsUserLoggedIn()
		{
			var loginStatus = System.Web.HttpContext.Current.Session["LoginStatus"] as string;
			return loginStatus == "login";
		}

		private UserMinimal GetCurrentLoggedInUser()
		{
			return System.Web.HttpContext.Current.GetMySessionObject(); 
		}

		[HttpPost]
		public async Task<ActionResult> Index(UserBooking booking)
		{
			UBookingData data = new UBookingData()
			{
				Username = booking.Name,
				Email = booking.Email,
				CheckIn = booking.CheckIn,
				CheckOut = booking.CheckOut,
				RoomType = booking.RoomType
			};

			var userbooking = await _session.UserBooking(data);
			switch (userbooking.Status)
			{
				case 1:
					ViewBag.ErrorMessage = "Invalid username";
					break;
				case 2:
					ViewBag.ErrorMessage = "Invalid date, cant pick a Check Out date before Check In";
					break;
				case 3:
					//add to check last in db for roomtype in reservat(ultima data checkout pentru roomtype), and add in mesaj cand va fi disponibil
					ViewBag.ErrorMessage = $"Sorry, room is already booked between {data.CheckIn} and {data.CheckOut}";
					break;
				case 4:
					ViewBag.SuccesMessage = "Room booked successfully!";
					break;
			}
			return View();
		}

	}
}