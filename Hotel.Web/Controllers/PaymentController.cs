using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Hotel.BusinessLogic.Interfaces;
using Hotel.Web.Models;
using Stripe;

namespace Hotel.Web.Controllers
{
    public class PaymentController : Controller
    {
	    private readonly ISession _session;
	    public PaymentController()
	    {
		    var bl = new BusinessLogic.BusinessLogic();
		    _session = bl.GetSessionBL();
	    }
        // GET: Payment
        public ActionResult Index()
        {
            return View();
        }

       [HttpPost]
          public async Task<ActionResult> ProcessPayment(PaymentModels model)
          {
              var charge = await _session.PaymentProcess(model);
              if (charge is Charge stripeCharge && stripeCharge.Status == "succeeded")
              {
                  // Payment succeeded
                  return RedirectToAction("Success");
              }
              else
              {
                  // Payment failed
                  return RedirectToAction("Failure");
              }
          }

          public ActionResult Success()
          {
              return View();
          }

          public ActionResult Failure()
          {
              return View();
          }
    }
}