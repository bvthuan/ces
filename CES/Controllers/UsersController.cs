using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CES.Database.Context;
using CES.Database.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using CES.Extension;
using CES.Model;
using CES.Services;

namespace CES.Controllers
{
	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
	[Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CesContext _context;
		private readonly IUser _userService;

		public UsersController(CesContext context, IUser userService)
        {
            _context = context;
			_userService = userService;
		}

        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _context.Users;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser([FromRoute] long id, [FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

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
			_context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }

        private bool UserExists(long id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

		[AllowAnonymous]
		[HttpPost("authenticate")]
		public async Task<IActionResult> Authenticate([FromBody]UserAuthenticationModel user)
		{
			var canLogin = await _userService.IsCorrectPassword(user.Username, user.Password);
			if (!canLogin)
			{
				return BadRequest(new { message = "Username or password is incorrect" });
			}

			var userdata = await _userService.Get(user.Username);
			var result = userdata.GenerateToken();
			return Ok(result);
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
			return new UserModel
			{

			};
		}
	}
}