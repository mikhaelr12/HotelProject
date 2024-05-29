using Hotel.Domain.Entities.User;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Domain.Entities.Booking;
using Hotel.Domain.Enums;

namespace Hotel.BusinessLogic.Interfaces
{
	public interface ISessionAdmin
	{
		IEnumerable<UDBTable> GetAllUsers();
		void DeleteUser(string username);
		void ChangeRoomPricing(RoomType roomType, decimal newPrice);
		IEnumerable<BDBTable> GetBookings();
	}
}
