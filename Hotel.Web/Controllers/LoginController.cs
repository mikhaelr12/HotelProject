using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Hotel.BusinessLogic.Interfaces;
using Hotel.Domain.Entities.User;
using Hotel.Domain.Enums;
using Hotel.Web.Extentions;
using Hotel.Web.Models;

namespace Hotel.Web.Controllers
{
	public class LoginController : Controller
	{
		private readonly ISession _session;

		public LoginController()
		{
			var bl = new BusinessLogic.BusinessLogic();
			_session = bl.GetSessionBL();
		}

		// GET: Login
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(UserLogin login)
		{
			if (ModelState.IsValid)
			{
				var data = Mapper.Map<ULoginData>(login);
				var userLogin = _session.UserLogin(data);
				if (userLogin.Status)
				{
					if (userLogin.IsAdmin)
					{
						System.Web.HttpContext.Current.Session["LoginStatus"] = "login";
						HttpCookie cookie = _session.GenCookie(login.Credential);
						ControllerContext.HttpContext.Response.Cookies.Add(cookie);
						return RedirectToAction("Index", "Admin");
					}

					else
					{
						System.Web.HttpContext.Current.Session["LoginStatus"] = "login";
						HttpCookie cookie = _session.GenCookie(login.Credential);
						ControllerContext.HttpContext.Response.Cookies.Add(cookie);
						return RedirectToAction("Index", "Home");
					}
				}
				else
				{
					ModelState.AddModelError("", userLogin.StatusMessage);
					return View();
				}
			}
			return View();
		}

		public ActionResult Logout()
		{
			System.Web.HttpContext.Current.Session["LoginStatus"] = "logout";
			return RedirectToAction("Index", "Home");
		}
	}
}