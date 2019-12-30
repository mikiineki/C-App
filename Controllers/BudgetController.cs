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
    public class BudgetController : BaseController
    {
        public BudgetController(Project1Context context = null) : base(context)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Budgets.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var budget = _context.Budgets.Find(Id);
            return Ok(budget);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Budget budget)
        {
            _context.Add(budget);
            _context.SaveChanges();
            return Ok(budget);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Budget newBudget)
        {
            Budget oldBudget = _context.Budgets.Find(Id);
            _context.Entry(oldBudget).CurrentValues.SetValues(newBudget);
            _context.SaveChanges();
            return Ok(newBudget);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int Id)
        {
            Budget oldBudget = _context.Budgets.Find(Id);
            _context.Budgets.Remove(oldBudget);
            _context.SaveChanges();
            return NoContent();
        }
    }
}