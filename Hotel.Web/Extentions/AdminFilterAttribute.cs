using Hotel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Hotel.Web.Extentions
{
	public class AdminFilterAttribute : ActionFilterAttribute
	{
		private readonly ISession _session;
		public AdminFilterAttribute()
		{
			var bl = new BusinessLogic.BusinessLogic();
			_session = bl.GetSessionBL();
		}
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			var apiCookie = HttpContext.Current.Request.Cookies["X-KEY"];
			if (apiCookie != null)
			{
				var profile = _session.GetUserByCookie(apiCookie.Value);
				if(profile != null && profile.Role == Domain.Enums.URole.Admin) 
				{
					HttpContext.Current.SetMySessionObject(profile);
				}

				else
				{
					filterContext.Result = new RedirectToRouteResult(new
						System.Web.Routing.RouteValueDictionary (new {controller = "error", action = "error404"}));
				}
			}
		}
	}
}