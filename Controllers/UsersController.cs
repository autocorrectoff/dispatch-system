using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dispatch_system.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = new Dictionary<string, string>();
            user.Add(id.ToString(), "hardcoded response");
            return Ok(user);
        }
    }
}