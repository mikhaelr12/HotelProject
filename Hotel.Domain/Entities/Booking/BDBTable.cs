using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Domain.Entities.Room;
using Hotel.Domain.Entities.User;

namespace Hotel.Domain.Entities.Booking
{
	public class BDBTable
	{
		[Key]
		public int BookingId { get; set; }
		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set; }
		public decimal FinalPrice { get; set; }
		public UDBTable User { get; set; }
		public RDBTable Room { get; set; }
	}
}
