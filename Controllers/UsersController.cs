using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dispatch_system.Core;
using dispatch_system.Core.Models;
using dispatch_system.Dtos;
using dispatch_system.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Microsoft.Extensions.Primitives;

namespace dispatch_system.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public UsersController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = new Dictionary<string, string>();
            user.Add(id.ToString(), "hardcoded response");
            return Ok(user);
        }

        [HttpPost("create")]
        public IActionResult Create(UserDto dto)
        {
            // TODO: use jwt auth
            StringValues id = string.Empty;
            Request.Headers.TryGetValue("user_id", out id);
            if(string.IsNullOrEmpty(id.ToString()))
            {
                return Unauthorized("Unauthorized access blocked. Please log in as admin");
            }
            User loggedInUser = _uow.Users.GetUser(int.Parse(id.ToString()));
            if(loggedInUser.UserType.ToLower() != "admin")
            {
                return Unauthorized("Unauthorized access blocked. Please log in as admin");
            }
            // TODO: consider using automapper
            var user = new User { Name = dto.Name, Email = dto.Email, Password = HasherUtil.Hash(dto.Password), Phone = dto.Phone, State = dto.State, IsActive = dto.IsActive, DateAdded = DateTime.Now, Notes = dto.Notes, UserType = dto.UserType };
            _uow.Users.AddUser(user);
            _uow.Complete();
            return Ok();
        }
    }
}