using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyProject.WebApi.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _conﬁguration;
        public AuthController(IConfiguration conﬁguration) { _conﬁguration = conﬁguration; }
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            if (loginModel.UserName == "shira" && loginModel.Password == "1234")
            {
      
                var claims = new List<Claim>() {
                    new Claim(ClaimTypes.Actor, "213118904"),
                    new Claim(ClaimTypes.Name, "shira"),
                    new Claim(ClaimTypes.Role, "student")
                };

                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_conﬁguration.GetValue<string>("JWT:Key")));

                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokeOptions = new JwtSecurityToken(
                    issuer: _conﬁguration.GetValue<string>("JWT:Issuer"),
                    audience: _conﬁguration.GetValue<string>("JWT:Audience"),
                    claims: claims,
                    expires: DateTime.Now.AddSeconds(30),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString });
            }
            return Unauthorized();
        }
    }

}
       
