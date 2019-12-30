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
    public class CoachController : BaseController
    {
        public CoachController(Project1Context context = null) : base(context)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Coaches.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var coach = _context.Coaches.Find(Id);
            return Ok(coach);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Coach coach)
        {
            _context.Add(coach);
            _context.SaveChanges();
            return Ok(coach);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Coach newCoach)
        {
            Coach oldCoach = _context.Coaches.Find(Id);
            _context.Entry(oldCoach).CurrentValues.SetValues(newCoach);
            _context.SaveChanges();
            return Ok(newCoach);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int Id)
        {
            Coach oldCoach = _context.Coaches.Find(Id);
            _context.Coaches.Remove(oldCoach);
            _context.SaveChanges();
            return NoContent();
        }
    }
}