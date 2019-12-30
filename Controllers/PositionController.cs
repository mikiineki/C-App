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
    public class PositionController : BaseController
    {
        public PositionController(Project1Context context = null) : base(context)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Positions.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var position = _context.Positions.Find(Id);
            return Ok(position);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Position position)
        {
            _context.Add(position);
            _context.SaveChanges();
            return Ok(position);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Position newPosition)
        {
            Position oldPosition = _context.Positions.Find(Id);
            _context.Entry(oldPosition).CurrentValues.SetValues(newPosition);
            _context.SaveChanges();
            return Ok(newPosition);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int Id)
        {
            Position oldPosition = _context.Positions.Find(Id);
            _context.Positions.Remove(oldPosition);
            _context.SaveChanges();
            return NoContent();
        }
    }
}