using System;
using System.Collections.Generic;

namespace CES.Database.Models
{
	public class User : Entity
	{
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
