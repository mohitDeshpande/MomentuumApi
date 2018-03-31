using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MomentuumApi.Model.CivicTrack;
using Microsoft.AspNetCore.Authorization;

namespace MomentuumApi.Controllers
{
    [Produces("application/json")]
    [Route("api/CaseType")]
    public class CaseTypeController : Controller
    {
        private readonly CivicTrackContext _context;

        public CaseTypeController(CivicTrackContext context)
        {
            _context = context;
        }


    }
}