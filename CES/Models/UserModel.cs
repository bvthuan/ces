using System;
using System.Collections.Generic;
using System.Text;

namespace CES.Model
{
	public class UserModel
	{
		public long Id { get; set; }

		public string Username { get; set; }
	}

	public class Account : UserModel
	{
		public string Token { get; internal set; }
	}
}
