using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecretController : Controller
    {
        [Authorize]
        [HttpGet]
        public string Index()
        {
            return "secret message";
        }
    }
}
