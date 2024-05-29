using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Hotel.BusinessLogic.Interfaces;
using Hotel.Domain.Entities.Admin;
using Hotel.Domain.Entities.User;
using Hotel.Domain.Enums;
using Hotel.Web.Extentions;
using Hotel.Web.Models;

namespace Hotel.Web.Controllers
{
    public class AdminController : Controller
    {
	    private readonly ISession _session;
		private readonly ISessionAdmin _admin;

	    public AdminController()
	    {
		    var bl = new BusinessLogic.BusinessLogic();
		    _session = bl.GetSessionBL();
		    _admin = bl.GetAdminSessionBL();
	    }
        // GET: Admin
        [AdminFilter]
        public ActionResult Index()
        {
	        
            return View();
        }


		[HttpGet]
        public ActionResult Index(Users user)
        {
	        var usersFromDb = _admin.GetAllUsers();
	        var users = usersFromDb.Select(u => new Users
	        {
		        Username = u.Username,
		        Email = u.Email,
				Role = u.Role
				
	        });
			return View(users);
        }

        public ActionResult DeleteUser(string username)
        {
	        _admin.DeleteUser(username);
			return RedirectToAction("Index");
        }

        public ActionResult Rooms(string username)
        {
	        var roomsFromDB = _session.GetAllRoomTypes();
	        var rooms = roomsFromDB.Select(rt => new Rooms
	        {
		        RoomType = rt.RoomType,
		        Price = rt.Price,
		        RoomId = rt.Id
	        });
	        return View(rooms);
        }

        public ActionResult ChangeRoomPrice(RoomType roomType,decimal newPrice)
        {
	        _admin.ChangeRoomPricing(roomType, newPrice);
			return RedirectToAction("Rooms");
        }

        public ActionResult Bookings()
        {
	        var getBookingsFromDB = _admin.GetBookings();
	        var mappedBookings = getBookingsFromDB.Select(b => new Bookings
	        {
				BookindId = b.BookingId,
				CheckIn = b.CheckInDate,
				CheckOut = b.CheckOutDate,
				FinalPrice = b.FinalPrice
	        });
			return View(mappedBookings);
        }
	}
}