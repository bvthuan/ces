using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CES.Database.Context;
using CES.Database.Models;
using CES.Services;
using Microsoft.AspNetCore.Authorization;
using CES.Model;
using CES.Extension;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace CES.Controllers
{
	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
	[Route("api/[controller]")]
	[ApiController]
	public class UsersControllerv1 : ControllerBase
	{
		private readonly IUser _userService;

		public UsersControllerv1(IUser userService)
		{
			_userService = userService;
		}

		// GET: api/Users
		[HttpGet]
		public async Task<IActionResult> GetUsers()
		{
			return Ok(await _userService.Users());
		}

		//// GET: api/Users/5
		//[HttpGet("{id}")]
		//public async Task<IActionResult> GetUser([FromRoute] long id)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		return BadRequest(ModelState);
		//	}
		//	return null;
		//	//var user = await _context.Users.FindAsync(id);

		//	//if (user == null)
		//	//{
		//	//    return NotFound();
		//	//}

		//	//return Ok(user);
		//}

		//// PUT: api/Users/5
		//[HttpPut("{id}")]
		//public async Task<IActionResult> PutUser([FromRoute] long id, [FromBody] User user)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		return BadRequest(ModelState);
		//	}

		//	if (id != user.Id)
		//	{
		//		return BadRequest();
		//	}

		//	await _userService.AddUser(user);

		//	return NoContent();
		//}

		// POST: api/Users
		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> PostUser([FromBody] User user)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			user.Password = user.Password.HashPassword();
			await _userService.AddUser(user);

			return CreatedAtAction("GetUser", new { id = user.Id }, user);
		}

		//// DELETE: api/Users/5
		//[HttpDelete("{id}")]
		//public async Task<IActionResult> DeleteUser([FromRoute] long id)
		//{
		//	return BadRequest(ModelState);
		//}

		[AllowAnonymous]
		[HttpPost("authenticate")]
		public async Task<IActionResult> Authenticate([FromBody]UserAuthenticationModel user)
		{
			var canLogin = await _userService.IsCorrectPassword(user.Username, user.Password);
			if (canLogin)
			{
				return BadRequest(new { message = "Username or password is incorrect" });
			}

			var userdata = await _userService.Get(user.Username);
			var result = userdata.GenerateToken();
			return Ok(result);
		}
	}
}