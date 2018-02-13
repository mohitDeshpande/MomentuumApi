using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MomentuumApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MomentuumApi.Controllers
{
    [Route("api/auth/[action]")]
    public class AuthenticationController : Controller
    {

        private IConfiguration _config;
        private readonly MobileDBContext _context;

        public AuthenticationController(IConfiguration config, MobileDBContext context) 
        {
            _config = config;
            _context = context;
        }

        // POST api/auth/login
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody]LoginModel login)
        {
            IActionResult response = Unauthorized();

            TblEmployees employee = _context.TblEmployees.FirstOrDefault(emp => emp.EmployeeLogin.Equals(login.Username));

            if (employee != null && employee.UsrPassword.Equals(login.Password)) {
                var tokenString = BuildToken(login);

                response = Ok(new { token = tokenString });
            }

            return response;
        }

        /// <summary>
        /// Builds the JwtToken.
        /// The token consists of the encoded username under the claim JwtRegisteredClaimNames.NameId
        /// </summary>
        /// <returns>Built JWT token as an encoded string</returns>
        private string BuildToken(LoginModel user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.NameId, user.Username)
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                                             _config["Jwt:Issuer"],
                                             claims,
                                             expires: DateTime.Now.AddDays(Double.Parse(_config["Jwt:ExpireDays"])),
                                             signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
