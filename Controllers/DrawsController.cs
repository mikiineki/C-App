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
    public class DrawsController : BaseController
    {
        public DrawsController(Project1Context context = null) : base(context)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Draws.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var draws = _context.Draws.Find(Id);
            return Ok(draws);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Draws draws)
        {
            _context.Add(draws);
            _context.SaveChanges();
            return Ok(draws);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Draws newDraws)
        {
            Draws oldDraws = _context.Draws.Find(Id);
            _context.Entry(oldDraws).CurrentValues.SetValues(newDraws);
            _context.SaveChanges();
            return Ok(newDraws);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int Id)
        {
            Draws oldDraws = _context.Draws.Find(Id);
            _context.Draws.Remove(oldDraws);
            _context.SaveChanges();
            return NoContent();
        }
    }
}