using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController
    {
        [HttpPost]
        public IActionResult SignUp([FromBody] User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult Login([FromBody] User user)
        {
            User loggedUser = _context.Users.Where(x => x.Username == user.Username && x.Password == user.Password).FirstOrDefault();
            return Ok(loggedUser);
        }
    }
}