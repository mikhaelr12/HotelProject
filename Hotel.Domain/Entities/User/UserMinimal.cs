using Hotel.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Entities.User
{
	public class UserMinimal
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public URole Role { get; set; }

	}
}
