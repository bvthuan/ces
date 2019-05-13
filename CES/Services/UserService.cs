using CES.Database.Context;
using CES.Database.Models;
using CES.Extension;
using CES.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CES.Services
{
	public class UserService : IUser
	{
		public CesContext _context;
		public UserService(CesContext context)
		{
			_context = context;
		}

		public async Task AddUser(User user)
		{
			_context.Users.Add(user);
			await _context.SaveChangesAsync();
		}

		public async Task<List<User>> Users()
		{
			return await _context.Users.ToListAsync();
		}

		public async Task<bool> IsCorrectPassword(string username, string password)
		{
			var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
			if (user == null)
				return false;

			return password.HashPassword() == user.Password;
		}

		/// <summary>
		/// Get user
		/// </summary>
		public async Task<UserModel> Get(string username)
		{
			var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
			return new UserModel {
				Id = user.Id,
				Username = user.Username
			};
		}
	}
}
