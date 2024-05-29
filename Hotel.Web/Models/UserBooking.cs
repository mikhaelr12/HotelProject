using Hotel.Domain.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Web.Models
{
	public class UserBooking
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime CheckIn { get; set; }
		public DateTime CheckOut { get; set; }
		public RoomType RoomType { get; set; }
		public decimal FinalPrice { get; set; }

		
	}
}