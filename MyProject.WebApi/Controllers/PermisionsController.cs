using Microsoft.AspNetCore.Mvc;
using MyProject.Repositoties;
using MyProject.Repositoties.Interfaces;
using MyProject.WebApi.Models;
using System.Collections.Generic;
using System.Reflection;

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
        public Permission Post(int id, string name, string description)//
        {
            return _permissionRepository.Add(id, name, description);
        }

        // PUT api/<PermisionsController>/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] PermmisionModel model)//update
        {
            var permission = _permissionRepository.GetById(id);
            permission.Name = model.Name;
            permission.Description = model.Description;
            _permissionRepository.Update(permission);
        }

        // DELETE api/<PermisionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _permissionRepository.Delete(id);
        }
    }
}
