using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Web.Models
{
	public class PaymentModel
	{
		public string CardNumber { get; set; }
		public string ExpMonth { get; set; }
		public string ExpYear { get; set; }
		public string Cvc { get; set; }
		public long Amount { get; set; } // Amount in cents
		public string Currency { get; set; } = "usd";
	}
}