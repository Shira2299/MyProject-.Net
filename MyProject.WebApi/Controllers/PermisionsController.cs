using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProject.Common.DTOs;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using MyProject.WebApi.Models;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class PermisionsController : ControllerBase
    {
        private readonly IPermmisionServices _permissionService;
        private readonly ILogger<IPermmisionServices> _logger;
        public PermisionsController(IPermmisionServices permissionService,ILogger<IPermmisionServices> logger)
        {
            _permissionService = permissionService;
            _logger = logger;
        }

        // GET: api/<PermisionsController>
        [HttpGet]
        public async Task<List<PermissionDTO>> Get()
        {
            return await _permissionService.GetListAsync();
        }

        // GET api/<PermisionsController>/5
        [HttpGet("{id}")]
        public async Task<PermissionDTO> Get(int id)
        {
            return await _permissionService.GetByIdAsync(id);
        }
     
        // POST api/<PermisionsController>
        [HttpPost]
        public async Task<int> Post([FromBody] PermmisionModel p)//add
        {
            var newPermmision = await _permissionService.AddAsync(p.Name, p.Description);
            return newPermmision.Id;
        }

        // PUT api/<PermisionsController>/5
        [HttpPut("{id}")]
        public async Task Put(int id,[FromBody] PermmisionModel model)//update
        {
            var permission = await _permissionService.GetByIdAsync(id);
            permission.Name = model.Name;
            permission.Description = model.Description;
            await _permissionService.UpdateAsync(permission);
        }

        // DELETE api/<PermisionsController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
          await  _permissionService.DeleteAsync(id);
        }
    }
}
