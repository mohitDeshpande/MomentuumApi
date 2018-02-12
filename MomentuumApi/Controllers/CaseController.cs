using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MomentuumApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

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
		
		// GET: api/case/{id}
        [HttpGet("{id}", Name = "GetCaseInfo"), Authorize]
		public IActionResult GetById(int id)
		{
			var item = _context.TblCase.FirstOrDefault(t => t.Id == id);
			var res = _context.TblClient
		.Where(z => z.Id == id)
		.Include(y => y.TblCase)
		.ToList();

			if (res == null)
			{
				return NotFound();
			}
			return new ObjectResult(res);
		}
	}
}
