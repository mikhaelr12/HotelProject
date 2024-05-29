using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hotel.Domain.Enums;

namespace Hotel.Web.Models
{
	public class Users
	{
		public string Username { get; set; }
		public string Email { get; set; }
		public URole Role { get; set; }
	}
}