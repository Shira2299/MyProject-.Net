using Microsoft.AspNetCore.Mvc;
using MyProject.Repositoties;
using MyProject.Repositoties.Interfaces;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly IClaimRepository _claimRepository;

        public ClaimsController(IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }

        // GET: api/<ClaimsController>
        [HttpGet]
        public IEnumerable<claim> Get()
        {
            return _claimRepository.GetAll();
        }

        // GET api/<ClaimsController>/5
        [HttpGet("{id}")]
        public claim Get(int id)
        {
            return _claimRepository.GetById(id);    
        }

        // POST api/<ClaimsController>
        [HttpPost]
        public claim Post(claim c)//update
        {
            return _claimRepository.Update(c);
        }

        // PUT api/<ClaimsController>/5
        [HttpPut("{id}")]
        public claim Put(int id, int RoleId, int PermissionId)//add
        {
            return _claimRepository.Add(id, RoleId, PermissionId);
        }

        // DELETE api/<ClaimsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }
    }
}
