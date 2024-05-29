using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Domain.Enums;

namespace Hotel.Domain.Entities.Room
{
	public class RDBTable
	{
		[Key]
		public int Id { get; set; }
		public RoomType RoomType { get; set; }
		public decimal Price { get; set; }
	}
}
