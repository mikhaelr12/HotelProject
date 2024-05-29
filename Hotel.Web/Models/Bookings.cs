using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hotel.Domain.Entities.Room;
using Hotel.Domain.Entities.User;

namespace Hotel.Web.Models
{
	public class Bookings
	{
		public int BookindId { get; set; }
		public DateTime CheckIn { get; set; }
		public DateTime CheckOut { get; set; }
		public decimal FinalPrice { get; set; }
		public UDBTable User { get; set; }
		public RDBTable Room { get; set; }
	}
}