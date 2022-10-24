using Microsoft.AspNetCore.Mvc;
using MyProject.Repositoties;
using MyProject.Repositoties.Interface;
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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RolesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _emailManager.Send("Shiram33993@gmail.com");
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
