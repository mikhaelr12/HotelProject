using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Hotel.BusinessLogic.Core;
using Hotel.BusinessLogic.Interfaces;
using Hotel.Domain.Entities.Admin;
using Hotel.Domain.Entities.Booking;
using Hotel.Domain.Entities.Room;
using Hotel.Domain.Entities.User;
using Hotel.Domain.Enums;
using Hotel.Web.Models;

namespace Hotel.BusinessLogic
{
	public class SessionBL : UserApi, ISession
	{
		public ULoginResp UserLogin(ULoginData data)
		{
			return UserLoginAction(data);
		}

		public HttpCookie GenCookie(string loginCredential)
		{
			return Cookie(loginCredential);
		}

		public UserMinimal GetUserByCookie(string apiCookieValue)
		{
			return UserCookie(apiCookieValue);
		}

		public URegisterResp UserRegistration(URegisterData data)
		{
			return UserRegisterAction(data);
		}

		public IEnumerable<RDBTable> GetAllRoomTypes()
		{
			return GetAllRoomTypesAction();
		}
		public Task<UBookingResp> UserBooking(UBookingData data)
		{
			return UserBookingLogic(data);
		}
		public List<DateTime> GetBookedDatesByRoomType(RoomType roomType)
		{
			return GetBookedDatesByRoomTypeAction(roomType);
		}

		public IEnumerable<BDBTable> GetUsersBookings(string username)
		{
			return GetUsersBookingsAction(username);
		}

		public void CancelBooking(DateTime checkInDate, RoomType roomType)
		{
			CancelBookingAction(checkInDate, roomType);
		}

		public Task<object> PaymentProcess(PaymentModels model)
		{
			return PaymentProcessAction(model);
		}

	}
}
