using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProject.Common.DTOs;
using MyProject.Repositories;
using MyProject.Repositories.Interface;
using MyProject.Services.Interfaces;
using MyProject.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RolesController : ControllerBase
    {
        // private readonly IEmailManager _emailManager;
        private readonly IRoleService _roleService;
        private readonly ILogger<RolesController> _logger;

        //public RolesController(IEmailManager emailManager, IRoleRepository roleRepository)
        //{
        //    _emailManager = emailManager;
        //    _roleRepository = roleRepository;
        //}
        public RolesController(IRoleService roleService, ILogger<RolesController> logger)
        {
            _roleService = roleService;
            _logger = logger;
        }

        // GET: api/<RolesController>
        [HttpGet]
        public async Task<List<RoleDTO>> Get()
        {
            return await _roleService.GetListAsync();
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoleDTO>> Get(int id)
        {
            var role = await _roleService.GetByIdAsync(id);
            if(role is null)
                return NotFound();
            return Ok(role);
        }
        
        // POST api/<RolesController>
        [HttpPost]
        public async Task<int> Post([FromBody] RoleModel r)//add
        {
            // _emailManager.Send("Shiram33993@gmail.com");
         var newRole= await _roleService.AddAsync(r.Name,r.Description);     
            return newRole.Id;
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody]RoleModel model)//update
        {
            await _roleService.UpdateAsync(new RoleDTO { Id = id, Name = model.Name, Title = model.Description });          
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
           await _roleService.DeleteAsync(id);
        }
    }
}
