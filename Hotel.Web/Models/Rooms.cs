using Hotel.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Web.Models
{
	public class Rooms
	{
		public RoomType RoomType { get; set; }
		public decimal Price { get; set; }
		public int RoomId { get; set; }
	}
}