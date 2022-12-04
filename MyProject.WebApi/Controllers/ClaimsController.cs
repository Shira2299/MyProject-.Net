using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProject.Common.DTOs;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using MyProject.WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClaimsController : ControllerBase
    {
        private readonly IClaimServices _claimService;
        private readonly ILogger<IClaimServices> _logger;

        public ClaimsController(IClaimServices claimService, ILogger<IClaimServices> logger)
        {
            _claimService = claimService;
            _logger = logger;
        }

        // GET: api/<ClaimsController>
        [HttpGet]
        public async Task<List<ClaimDTO>> Get()
        {
            return await _claimService.GetListAsync();
        }

        // GET api/<ClaimsController>/5
        [HttpGet("{id}")]
        public async Task<ClaimDTO> Get(int id)
        {
            return await _claimService.GetByIdAsync(id);    
        }
       
        // POST api/<ClaimsController>
        [HttpPost]
        public async Task<int> Post([FromBody] ClaimModel c)//add
        {
            var newClaim=await _claimService.AddAsync(c.RoleId,c.PermissionId,c.epolicy); 
            return newClaim.Id;
        }

        // PUT api/<ClaimsController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ClaimModel model)//update
        {
            var claim = await _claimService.GetByIdAsync(id);
            claim.Role= model.RoleId;
            claim.Permission = model.PermissionId;
            claim.epolicy = model.epolicy;
            await _claimService.UpdateAsync(claim);
        }

        // DELETE api/<ClaimsController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
           await _claimService.DeleteAsync(id);
        }
    }
}
