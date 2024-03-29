﻿using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public UsersController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> Get()
        {
            var tmp = from first in _context.Roles
                      join second in _context.UserRoles on first.Id equals second.RoleId
                      join third in _context.Users on second.UserId equals third.Id
                      select new
                      {
                          third.Id,
                          third.UserName,
                          third.Email,
                          third.TeacherId,
                          Role = first.Name

                      };

            return await tmp.ToListAsync().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var value = await _context.Users.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("{userId}/{teacherId}")]
        public async Task<IActionResult> Get(string userId, int teacherId)
        {
            var user = await _context.Users.FindAsync(userId);
            user.TeacherId = teacherId;
            if (ModelState.IsValid)
            {
                _context.Update(user);
                await _context.SaveChangesAsync();
                return Ok(user);

            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<User>> Post(User value)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete(string id)
        {
            var value = await _context.Users.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.Users.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
