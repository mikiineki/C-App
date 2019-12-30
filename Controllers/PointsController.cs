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
    public class PointsController : BaseController
    {
        public PointsController(Project1Context context = null) : base(context)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Points.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var points = _context.Points.Find(Id);
            return Ok(points);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Points points)
        {
            _context.Add(points);
            _context.SaveChanges();
            return Ok(points);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Points newPoints)
        {
            Points oldPoints = _context.Points.Find(Id);
            _context.Entry(oldPoints).CurrentValues.SetValues(oldPoints);
            _context.SaveChanges();
            return Ok(newPoints);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int Id)
        {
            Points oldPoints = _context.Points.Find(Id);
            _context.Points.Remove(oldPoints);
            _context.SaveChanges();
            return NoContent();
        }
    }
}