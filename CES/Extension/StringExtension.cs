using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CES.Extension
{
	public static class StringExtension
	{
		public static string HashPassword(this string userPassword)
		{
			return userPassword;
		}
	}
}
