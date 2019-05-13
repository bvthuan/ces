using CES.Database.Models;
using CES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CES.Services
{
	public interface IUser
	{
		Task<List<User>> Users();
		Task AddUser(User user);
		Task<bool> IsCorrectPassword(string username, string password);
		Task<UserModel> Get(string username);
	}
}
