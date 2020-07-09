using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Controllers
{
    [Authorize]
    public class HomeController : ApiController
    {
        [HttpGet]

        public ActionResult Get()
        {
            return Ok("works");
        }
    }
}
