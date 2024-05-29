using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BusinessLogic.Interfaces;

namespace Hotel.BusinessLogic
{
	public class BusinessLogic
	{
		public ISession GetSessionBL()
		{
			return new SessionBL();
		}

		public ISessionAdmin GetAdminSessionBL()
		{
			return new SessionAdmin();
		}
	}
}
