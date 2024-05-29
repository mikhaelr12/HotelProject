using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Domain.Enums;

namespace Hotel.Domain.Entities.User
{
	public class ULoginResp
	{
		public bool Status { get; set; }
		public string StatusMessage { get; set; }

		public bool IsAdmin { get; set; }
	}
}
