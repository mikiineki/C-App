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
    public class LossesController : BaseController
    {
        public LossesController(Project1Context context = null) : base(context)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Losses.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var losses = _context.Losses.Find(Id);
            return Ok(losses);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Losses losses)
        {
            _context.Add(losses);
            _context.SaveChanges();
            return Ok(losses);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Losses newLosses)
        {
            Losses oldLosses = _context.Losses.Find(Id);
            _context.Entry(oldLosses).CurrentValues.SetValues(newLosses);
            _context.SaveChanges();
            return Ok(newLosses);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int Id)
        {
            Losses oldLosses = _context.Losses.Find(Id);
            _context.Losses.Remove(oldLosses);
            _context.SaveChanges();
            return NoContent();
        }
    }
}