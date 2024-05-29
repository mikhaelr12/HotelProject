using Hotel.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Entities.User
{
	public class UBookingData
	{
		public string Username { get; set; }
		public string Email { get; set; }
		public DateTime CheckIn { get; set; }
		public DateTime CheckOut { get; set; }
		public RoomType RoomType { get; set; }
	}
}
