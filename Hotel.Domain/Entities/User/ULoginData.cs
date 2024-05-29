using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Domain.Enums;

namespace Hotel.Domain.Entities.User
{
	public class ULoginData
	{
		public string Credential { get; set; }
		public string Password { get; set; }
		public string LoginIp { get; set; }
		public URole Role { get; set; }
		public bool Status { get; set; }
	}
}
