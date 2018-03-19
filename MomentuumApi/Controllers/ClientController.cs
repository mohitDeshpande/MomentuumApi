using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MomentuumApi.Model.CivicTrack;
using MomentuumApi.Utils;

namespace MomentuumApi.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	public class ClientController : Controller
	{
		private readonly CivicTrackContext _context;

		public ClientController(CivicTrackContext context)
		{
			_context = context;
		}

		// GET: api/client/division/{key}
		// getting all the client assigned to the division to which employee belongs
		[HttpGet("division/{key}"), Authorize]
		public IEnumerable<TblVoter> GetAll(string key)
		{
			var user = JwtHelper.GetUser(HttpContext.User.Claims);
			string keyToCheck = key.ToLower();
			var div = _context.TblEmployees.FirstOrDefault(empl => empl.EmployeeLogin.Equals(user)).Riding;
			
			return _context.TblVoter.Where(vot => vot.Riding.Equals(div))
				.Where(cli => cli.FirstName.ToLower().Contains(keyToCheck) || cli.Lastname.ToLower().Contains(keyToCheck))
				.ToList();
		}

		// get null list if no key was sent
		[HttpGet("division"), Authorize]
		public IEnumerable<TblVoter> GetNull()
		{
			return null;
		}

	}
}