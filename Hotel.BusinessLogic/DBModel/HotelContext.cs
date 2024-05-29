using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Domain.Entities.Booking;
using Hotel.Domain.Entities.Room;
using Hotel.Domain.Entities.User;

namespace Hotel.BusinessLogic.DBModel
{
	public class HotelContext : DbContext
	{
		public HotelContext() : base("name=HotelProject")
		{
			
		}
		public virtual DbSet<UDBTable> Users { get; set; }
		public virtual DbSet<RDBTable> Rooms { get; set; }
		public virtual DbSet<BDBTable> Bookings { get; set; }
		public virtual DbSet<Session> Sessions { get; set; }
	}
}
