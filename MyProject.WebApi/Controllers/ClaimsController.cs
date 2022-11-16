using Microsoft.AspNetCore.Mvc;
using MyProject.Repositoties;
using MyProject.Repositoties.Interfaces;
using MyProject.WebApi.Models;
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
        public IEnumerable<Claim> Get()
        {
            return _claimRepository.GetAll();
        }

        // GET api/<ClaimsController>/5
        [HttpGet("{id}")]
        public Claim Get(int id)
        {
            return _claimRepository.GetById(id);    
        }
       
        // POST api/<ClaimsController>
        [HttpPost]
        public Claim Post(int id, int RoleId, int PermissionId)//add
        {
            return _claimRepository.Add(id, RoleId, PermissionId);           
        }

        // PUT api/<ClaimsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClaimModel model)//update
        {
            var claim = _claimRepository.GetById(id);
            claim.RoleId = model.RoleId;
            claim.PermissionId = model.PermissionId;
            claim.epolicy = model.epolicy;       
            _claimRepository.Update(claim);
        }

        // DELETE api/<ClaimsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }
    }
}
