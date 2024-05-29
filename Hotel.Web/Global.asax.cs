using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using AutoMapper;
using Hotel.Domain.Entities.Admin;
using Hotel.Domain.Entities.User;
using Hotel.Web.Models;
using Hotel.Web.Stripe;
using Stripe;

namespace Hotel.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Mapper.Initialize(cfg =>
            {
	            cfg.CreateMap<UserLogin, ULoginData>();
	            cfg.CreateMap<UDBTable, UserMinimal>();
	            cfg.CreateMap<UserRegister, URegisterData>();
	            cfg.CreateMap<UserBooking, UBookingData>();
	            // Add other mappings as needed
            });
            var secretKey = ConfigurationManager.AppSettings["Stripe:SecretKey"];
            StripeConfiguration.ApiKey = secretKey;

            var stripeSettings = new StripeSettings
            {
	            SecretKey = secretKey,
	            PublishableKey = ConfigurationManager.AppSettings["Stripe:PublishableKey"]
            };
		}
    }
}
