using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MomentuumApi.Model;

namespace MomentuumApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CaseItemsController : Controller
    {
        private readonly MobileDBContext _context;

        public CaseItemsController(MobileDBContext context)
        {
            _context = context;
        }

        // GET: api/CaseItems/case/1234, in order to get case items for a specific case
        [Route("case/{id}")]
        [HttpGet, Authorize]
        public IEnumerable<TblCaseItem> GetTblCaseItemByCase([FromRoute] int? id)
        {
            return _context.TblCaseItem.Where(i => i.Caseid.Equals(id));
        }

        // GET: api/CaseItems
        [HttpGet, Authorize]
        public IEnumerable<TblCaseItem> GetTblCaseItem()
        {
            return _context.TblCaseItem;
        }
       


        // GET: api/CaseItems/5
        [HttpGet("{id}"), Authorize]
        public async Task<IActionResult> GetTblCaseItem([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblCaseItem = await _context.TblCaseItem.SingleOrDefaultAsync(m => m.IntId == id);

            if (tblCaseItem == null)
            {
                return NotFound();
            }

            return Ok(tblCaseItem);
        }

        // PUT: api/CaseItems/5
        [HttpPut("{id}"), Authorize]
        public async Task<IActionResult> PutTblCaseItem([FromRoute] int? id, [FromBody] TblCaseItem tblCaseItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblCaseItem.IntId)
            {
                return BadRequest();
            }

            _context.Entry(tblCaseItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCaseItemExists(id))
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

        // POST: api/CaseItems
        [HttpPost, Authorize]
        public async Task<IActionResult> PostTblCaseItem([FromBody] TblCaseItem tblCaseItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TblCaseItem.Add(tblCaseItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblCaseItem", new { id = tblCaseItem.IntId }, tblCaseItem);
        }

        // DELETE: api/CaseItems/5
        [HttpDelete("{id}"), Authorize]
        public async Task<IActionResult> DeleteTblCaseItem([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblCaseItem = await _context.TblCaseItem.SingleOrDefaultAsync(m => m.IntId == id);
            if (tblCaseItem == null)
            {
                return NotFound();
            }

            _context.TblCaseItem.Remove(tblCaseItem);
            await _context.SaveChangesAsync();

            return Ok(tblCaseItem);
        }

        private bool TblCaseItemExists(int? id)
        {
            return _context.TblCaseItem.Any(e => e.IntId == id);
        }
    }
}