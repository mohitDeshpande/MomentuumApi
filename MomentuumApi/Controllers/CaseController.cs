using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MomentuumApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using MomentuumApi.Utils;

namespace MomentuumApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CaseController : Controller
    {
        private readonly MobileDBContext _context;

        public CaseController(MobileDBContext context)
        {
            _context = context;
        }

        // GET: api/case
        [HttpGet, Authorize]
        public IEnumerable<TblCase> GetAll()
        {
            return _context.TblCase.ToList();
        }


        // GET api/case/{id}
        // getting the single case based on id
        [HttpGet("{id}"), Authorize]
        public IEnumerable<TblCase> GetCaseById(int id)
        {
            return _context.TblCase.Where(emp => emp.Caseid.Equals(id)).ToList();
        }


        // GET api/case/emp/{id}
        // getting all the cases assigned to the Employee based on empployeelogin
        [HttpGet("emp/{id}"), Authorize]
        public IEnumerable<TblCase> GetCaseByEmpId(string id)
        {
            return _context.TblCase.Where(emp => emp.CaseAssignedTo.Equals(id)).ToList();
        }



        // GET: api/case/client/emp
        // getting all the cases with client details assigned to the Employee based on employeelogin
        [HttpGet("client/emp"), Authorize]
        public IActionResult GetCaseClientByEmpJwt()
        {
            var user = JwtHelper.GetUser(HttpContext.User.Claims);

            var clientCase = _context.TblCase
                .Join(_context.TblClient, cas => cas.IdClient, cli => cli.Id, (cas, cli) => new { cas, cli })
                .Where(x => x.cas.CaseAssignedTo == user)
                .ToList();

            if (clientCase == null)
            {
                return NotFound();
            }
            return new ObjectResult(clientCase);
        }


        // GET: api/case/client/{id}
        // getting all the cases with client details by case id
        [HttpGet("client/{id}"), Authorize]
        public IActionResult GetCaseClientById(int id)
        {
     
            var clientCase = _context.TblCase
                .Join(_context.TblClient, cas => cas.IdClient, cli => cli.Id, (cas, cli) => new { cas, cli })
                .Where(x => x.cas.Caseid == id)
                .ToList();

            if (clientCase == null)
            {
                return NotFound();
            }
            return new ObjectResult(clientCase);
        }
    }
}
