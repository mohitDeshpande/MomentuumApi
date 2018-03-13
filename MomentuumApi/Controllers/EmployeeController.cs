using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MomentuumApi.Model.CivicTrack;
using MomentuumApi.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MomentuumApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly CivicTrackContext _context;

        public EmployeeController(CivicTrackContext context) 
        {
            _context = context;
        }

        // GET: api/employee
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            var employeeId = JwtHelper.GetUser(HttpContext.User.Claims);
            try
            {
                TblEmployees employee = _context.TblEmployees
                                                .Where(emp => emp.EmployeeLogin.Equals(employeeId))
                                                .Single();
                employee.UsrPassword = null;
                return new ObjectResult(employee);
            } catch (InvalidOperationException e) {
                Console.WriteLine(e);
                return NotFound();
            }
        }

    }
}
