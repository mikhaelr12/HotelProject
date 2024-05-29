using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Hotel.Domain.Entities.Admin;
using Hotel.Domain.Entities.Booking;
using Hotel.Domain.Entities.Room;
using Hotel.Domain.Entities.User;
using Hotel.Domain.Enums;
using Hotel.Web.Models;

namespace Hotel.BusinessLogic.Interfaces
{
	public interface ISession
	{
		ULoginResp UserLogin(ULoginData data);
		HttpCookie GenCookie(string loginCredential);
		UserMinimal GetUserByCookie(string apiCookieValue);
		URegisterResp UserRegistration(URegisterData data);
		IEnumerable<RDBTable> GetAllRoomTypes();
		Task<UBookingResp> UserBooking(UBookingData data);
		List<DateTime> GetBookedDatesByRoomType(RoomType roomType);
		IEnumerable<BDBTable> GetUsersBookings(string username);
		void CancelBooking(DateTime checkInDate, RoomType roomType);
		Task<object> PaymentProcess(PaymentModels model);
	}
}	
