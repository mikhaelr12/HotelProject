using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Domain.Enums;

namespace Hotel.Domain.Entities.User
{
	public class UDBTable
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		public string Email { get; set; }
		public URole Role { get; set; }
	}
}
