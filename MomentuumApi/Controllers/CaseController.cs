using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MomentuumApi.Model.CivicTrack;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using MomentuumApi.Utils;

namespace MomentuumApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CaseController : Controller
    {
        private readonly CivicTrackContext _context;

        public CaseController(CivicTrackContext context)
        {
            _context = context;
        }

        // GET: api/case
        [HttpGet, Authorize ]
        public IEnumerable<TblCase> GetAll()
        {
            return _context.TblCase.Where(emp => emp.Deleted.Equals("false")).ToList();
        }


        // GET api/case/{id}
        // getting the single case based on id
        [HttpGet("{id}"), Authorize]
        public IEnumerable<TblCase> GetCaseById(int id)
        {
            return _context.TblCase.Where(emp => emp.Caseid.Equals(id) && emp.Deleted.Equals("false")).ToList();
        }


        // GET api/case/emp/{id}
        // getting all the cases assigned to the Employee based on empployeelogin
        [HttpGet("emp/{id}"), Authorize]
        public IEnumerable<TblCase> GetCaseByEmpId(string id)
        {
            return _context.TblCase.Where(emp => emp.CaseAssignedTo.Equals(id) && emp.Deleted.Equals("false")).ToList();
        }



        // GET: api/case/client/emp
        // getting all the cases with client details assigned to the Employee based on employeelogin
        [HttpGet("client/emp"), Authorize]
        public IActionResult GetCaseClientByEmpJwt()
        {
            var user = JwtHelper.GetUser(HttpContext.User.Claims);
			var clientCase = _context.TblCase
                .Join(_context.TblVoter, cas => cas.IdVoter, cli => cli.Id, (cas, cli) => new { cas, cli })
                .Where(x => x.cas.CaseAssignedTo == user && x.cas.Deleted.Equals("false"))
				//.Include(caseS)
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
                .Join(_context.TblVoter, cas => cas.IdVoter, cli => cli.Id, (cas, cli) => new { cas, cli })
                .Where(x => x.cas.Caseid == id && x.cas.Deleted.Equals("false"))
                .ToList();

            if (clientCase == null)
            {
                return NotFound();
            }
            return new ObjectResult(clientCase);
        }

        // DELETE: api/case/5  -- Soft Delete
        [HttpDelete("{id}"), Authorize]
        public async Task<IActionResult> DeleteTblCase([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblCase = await _context.TblCase.SingleOrDefaultAsync(m => m.Caseid == id);
            if (tblCase == null)
            {
                return NotFound();
            }
            // Soft delete by changing value
            tblCase.Deleted = "true";
            await _context.SaveChangesAsync();

            return Ok(tblCase);
        }

        // PUT: api/Case/5
        [HttpPut("{id}"), Authorize]
        public async Task<IActionResult> PutTblCase([FromRoute] int? id, [FromBody] TblCase tblCase)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblCase.Caseid)
            {
                return BadRequest();
            }

            _context.Entry(tblCase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCaseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool TblCaseExists(int? id)
        {
            return _context.TblCase.Any(e => e.Caseid == id);
        }

    }
}
