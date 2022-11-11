using Microsoft.AspNetCore.Mvc;
using MyProject.Repositoties;
using MyProject.Repositoties.Interface;
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
    public class RolesController : ControllerBase
    {
        private readonly IEmailManager _emailManager;
        private readonly IRoleRepository _roleRepository;

        public RolesController(IEmailManager emailManager, IRoleRepository roleRepository)
        {
            _emailManager = emailManager;
            _roleRepository = roleRepository;
        }

        // GET: api/<RolesController>
        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return _roleRepository.GetAll();
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public Role Get(int id)
        {
            return _roleRepository.GetById(id);
        }
        
        //[FromBody] string value
        // POST api/<RolesController>
        [HttpPost]
        public Role Post(int id, string name, string description)//add
        {
            // _emailManager.Send("Shiram33993@gmail.com");
            return _roleRepository.Add(id, name, description);           
        }

        //int id, [FromBody] string value
        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]RoleModel model)//update
        {
            var role=_roleRepository.GetById(id);
            role.Name = model.Name;
            role.Description = model.Description;
            _roleRepository.Update(role);
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }
    }
}
