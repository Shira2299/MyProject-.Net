using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProject.Common.DTOs;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using MyProject.WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _userService;
        private readonly ILogger<IUserServices> _logger;
        public UsersController(IUserServices userService, ILogger<IUserServices> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        // GET: api/<PermisionsController>
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _userService.GetListAsync();
        }

        // GET api/<PermisionsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> Get(int id)
        {
            var use = await _userService.GetByIdAsync(id);//it does not run
            if(use is null)
                return NotFound();
            return Ok(use);
        }

        // POST api/<PermisionsController>
        [HttpPost]
        public async Task<int> Post([FromBody] UserModel u)//add
        {
            var newUser = await _userService.AddAsync(u.Name, u.Password);
            return newUser.Id;
        }

        // PUT api/<PermisionsController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] UserModel model)//update
        {        
             await _userService.UpdateAsync(new UserDTO { Id = id, Name = model.Name, Password = model.Password });        
        }

        // DELETE api/<PermisionsController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }
    }
}
