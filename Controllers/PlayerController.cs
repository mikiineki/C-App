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
    public class PlayerController : BaseController
    {
        public PlayerController(Project1Context context = null) : base(context)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Players.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var player = _context.Players.Find(Id);
            return Ok(player);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Player player)
        {
            _context.Add(player);
            _context.SaveChanges();
            return Ok(player);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Player newPlayer)
        {
            Player oldPlayer = _context.Players.Find(Id);
            _context.Entry(oldPlayer).CurrentValues.SetValues(newPlayer);
            _context.SaveChanges();
            return Ok(newPlayer);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int Id)
        {
            Player oldPlayer = _context.Players.Find(Id);
            _context.Players.Remove(oldPlayer);
            _context.SaveChanges();
            return NoContent();
        }
    }
}