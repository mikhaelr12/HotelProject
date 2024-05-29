using Hotel.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Web.Models
{
	public class PaymentModels
	{
		public int Amount { get; set; }
		public string Currency { get; set; }
		public string Token { get; set; } // Stripe token
		public int NumberOfDays { get; set; }
		public RoomType RoomType { get; set; }
	}
}