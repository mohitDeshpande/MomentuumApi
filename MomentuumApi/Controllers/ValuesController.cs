using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MomentuumApi.Utils;
using MomentuumApi.Model.CivicTrack;

namespace MomentuumApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly CivicTrackContext _context;

        public ValuesController(CivicTrackContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        // example of getting a user id from the jwt token
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            string user ="";

            try
            {
                user = JwtHelper.GetUser(HttpContext.User.Claims);
            }
            catch (KeyNotFoundException e)
            {
                return new ObjectResult(e);
            }

            var employee = _context.TblEmployees.Where(emp => emp.EmployeeLogin.Equals(user)).ToList();

            return new ObjectResult(employee);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}