using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BusinessLogic.Core;
using Hotel.BusinessLogic.Interfaces;
using Hotel.Domain.Entities.Booking;
using Hotel.Domain.Entities.User;
using Hotel.Domain.Enums;

namespace Hotel.BusinessLogic
{
	public class SessionAdmin : AdminApi, ISessionAdmin
	{
		public IEnumerable<UDBTable> GetAllUsers()
		{
			return GetAllUsersAction();
		}

		public void DeleteUser(string username)
		{
			 DeleteUserAction(username);
		}

		public void ChangeRoomPricing(RoomType roomType, decimal newPrice)
		{
			ChangeRoomPricingAction(roomType, newPrice);
		}

		public IEnumerable<BDBTable> GetBookings()
		{
			//return GetBookingsAction();
			return null;
		}

	}
}
