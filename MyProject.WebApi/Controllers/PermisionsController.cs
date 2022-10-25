using Microsoft.AspNetCore.Mvc;
using MyProject.Repositoties;
using MyProject.Repositoties.Interfaces;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisionsController : ControllerBase
    {
        private readonly IPermissionRepository _permissionRepository;
        public PermisionsController(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        // GET: api/<PermisionsController>
        [HttpGet]
        public IEnumerable<Permission> Get()
        {
            return _permissionRepository.GetAll();
        }

        // GET api/<PermisionsController>/5
        [HttpGet("{id}")]
        public Permission Get(int id)
        {
            return _permissionRepository.GetById(id);
        }

        // POST api/<PermisionsController>
        [HttpPost]
        public Permission Post(Permission r)//update
        {
            return _permissionRepository.Update(r);
        }

        // PUT api/<PermisionsController>/5
        [HttpPut("{id}")]
        public Permission Put(int id, string name, string description)//add
        {
            return _permissionRepository.Add(id, name, description);
        }

        // DELETE api/<PermisionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _permissionRepository.Delete(id);
        }
    }
}
