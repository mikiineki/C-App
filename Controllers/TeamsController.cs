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
    public class TeamsController : BaseController
    {
        public TeamsController(Project1Context context = null) : base(context)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Teams.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var team = _context.Teams.Find(Id);
            return Ok(team);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Team team)
        {
            _context.Add(team);
            _context.SaveChanges();
            return Ok(team);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Team newTeam)
        {
            Team oldTeam = _context.Teams.Find(Id);
            _context.Entry(oldTeam).CurrentValues.SetValues(newTeam);
            _context.SaveChanges();
            return Ok(newTeam);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int Id)
        {
            Team oldTeam = _context.Teams.Find(Id);
            _context.Teams.Remove(oldTeam);
            _context.SaveChanges();
            return NoContent();
        }
    }
}