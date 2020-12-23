using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CEWeb.Models;

namespace CEWeb.Controllers
{
    [RouteAttribute("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly DatabaseContext _databaseContext;
        public UsersController(DatabaseContext context)
        {
            _databaseContext = context;

            _databaseContext.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUSers() {
            return Ok(await _databaseContext.Users.ToArrayAsync());
        }



        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _databaseContext.Users.FindAsync(id);
            if (user == null) { return NotFound(); }
            return Ok(user);
        }


        [HttpPost]
        public async Task<ActionResult<User>> CreateUser([FromBody] User user)
        {
            if (user == null)
                return BadRequest();
            _databaseContext.Users.Add(user);
            await _databaseContext.SaveChangesAsync();

            return CreatedAtRoute(
                "GetUSER",
                new { id = user.userId },
                user
                );                                                       
        }

        [HttpPut("{id:int}")]
        public async Task <IActionResult> EditUser([FromRoute] int id, [FromBody] User user)
        {
            if (id != user.userId) return BadRequest();

            _databaseContext.Entry(user).State = EntityState.Modified;
            try
            {
                await _databaseContext.SaveChangesAsync();
            }
             catch(DbUpdateConcurrencyException)
            {
                if (_databaseContext.Users.Find(id)==null)
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

        [HttpDelete("{id:int}")]
        public async Task <ActionResult<User>> DeleteUser(int id)
        {
            var user = await _databaseContext.Users.FindAsync(id);
            if (user == null) { return NotFound(); }
            _databaseContext.Users.Remove(user);
            await _databaseContext.SaveChangesAsync();
            return user;




        }

    }

    


    }

