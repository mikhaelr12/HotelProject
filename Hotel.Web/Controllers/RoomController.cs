using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.BusinessLogic.Interfaces;
using Hotel.Web.Models;

namespace Hotel.Web.Controllers
{
    public class RoomController : Controller
    {
	    private readonly ISession _session;

	    public RoomController()
	    {
		    var bl = new BusinessLogic.BusinessLogic();
		    _session = bl.GetSessionBL();
	    }
        // GET: Room
        
        public ActionResult Index(IEnumerable<Rooms> rooms)
        {
	        var roomTypesFromDb = _session.GetAllRoomTypes();

	        rooms = roomTypesFromDb.Select(rt => new Rooms
	        {
		        RoomType = rt.RoomType,
		        Price = rt.Price,
		        RoomId = rt.Id
	        });

	        return View(rooms);
		}
    }
}