using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Hotel.BusinessLogic.Interfaces;
using Hotel.Domain.Entities.User;
using Hotel.Web.Models;

namespace Hotel.Web.Controllers
{
    public class RegistrationController : Controller
    {
	    private readonly ISession _session;
	    public RegistrationController()
	    {
		    var bl = new BusinessLogic.BusinessLogic();
		    _session = bl.GetSessionBL();
	    }
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserRegister login)
        {
	        if (ModelState.IsValid)
	        {
		        var data = Mapper.Map<URegisterData>(login);

				var registrationResponse = _session.UserRegistration(data);
		        if (registrationResponse.Status)
		        {
			        HttpCookie cookie = _session.GenCookie(login.Username);
			        ControllerContext.HttpContext.Response.Cookies.Add(cookie);
			        return RedirectToAction("Index", "Home");
		        }

		        else
		        {
			        ModelState.AddModelError("", registrationResponse.StatusMessage);
		        }
	        }
	        return View();
        }
	}
}