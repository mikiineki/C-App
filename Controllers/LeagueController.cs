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
    public class LeagueController : BaseController
    {
        public LeagueController(Project1Context context = null) : base(context)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Leagues.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var league = _context.Leagues.Find(Id);
            return Ok(league);
        }

        [HttpPost]
        public IActionResult Post([FromBody] League league)
        {
            _context.Add(league);
            _context.SaveChanges();
            return Ok(league);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] League newLeague)
        {
            League oldLeague = _context.Leagues.Find(Id);
            _context.Entry(oldLeague).CurrentValues.SetValues(newLeague);
            _context.SaveChanges();
            return Ok(newLeague);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int Id)
        {
            League oldLeague = _context.Leagues.Find(Id);
            _context.Leagues.Remove(oldLeague);
            _context.SaveChanges();
            return NoContent();
        }
    }
}