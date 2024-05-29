using Hotel.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BusinessLogic.DBModel;
using Hotel.Domain.Enums;
using Hotel.Domain.Entities.Booking;

namespace Hotel.BusinessLogic.Core
{
	public class AdminApi
	{
		internal IEnumerable<UDBTable> GetAllUsersAction()
		{
			using (var context = new HotelContext())
			{
				var users = context.Users.ToList();
				var mappedUsers = users.Select(user => new UDBTable
				{

					Username = user.Username,
					Email = user.Email,
					Role = user.Role

				});
				return mappedUsers;
			}
		}

		internal void DeleteUserAction(string username)
		{
			using (var context = new HotelContext())
			{
				var result = context.Users.FirstOrDefault(u => u.Username == username);
				if (result != null)
				{
					context.Users.Remove(result);
					context.SaveChanges();
				}
			}
		}

		internal void ChangeRoomPricingAction(RoomType roomType,decimal newPrice)
		{
			using (var context = new HotelContext())
			{
				var result = context.Rooms.FirstOrDefault(r => r.RoomType == roomType);
				if (result != null)
				{
					result.Price = newPrice;
					context.SaveChanges();
				}
			}
		}

		internal IEnumerable<BDBTable> GetBookings()
		{
			using (var context = new HotelContext())
			{
				var bookings = context.Bookings.Include(b => b.Room).Include(u => u.User).ToList();
				var mappedBookings = bookings.Select(b => new BDBTable
				{
					BookingId = b.BookingId,
					CheckInDate = b.CheckInDate,
					CheckOutDate = b.CheckOutDate,
					FinalPrice = b.FinalPrice,
					User = b.User,
					Room = b.Room
				});
				return mappedBookings;
			}
		}

	}
}
