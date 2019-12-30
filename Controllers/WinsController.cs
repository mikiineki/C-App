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
    public class WinsController : BaseController
    {
        public WinsController(Project1Context context = null) : base(context)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Wins.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var wins = _context.Wins.Find(Id);
            return Ok(wins);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Wins wins)
        {
            _context.Add(wins);
            _context.SaveChanges();
            return Ok(wins);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Wins newWins)
        {
            Wins oldWins = _context.Wins.Find(Id);
            _context.Entry(oldWins).CurrentValues.SetValues(newWins);
            _context.SaveChanges();
            return Ok(newWins);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int Id)
        {
            Wins oldWins = _context.Wins.Find(Id);
            _context.Wins.Remove(oldWins);
            _context.SaveChanges();
            return NoContent();
        }
    }
}