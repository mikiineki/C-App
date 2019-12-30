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
    public class BaseController : ControllerBase
    {
        protected Project1Context _context;

        public BaseController()
        {
            _context = new Project1Context();
        }

        public BaseController(Project1Context context = null)
        {
            if(context != null)
            {
                _context = new Project1Context();
            }
        }
    }
}