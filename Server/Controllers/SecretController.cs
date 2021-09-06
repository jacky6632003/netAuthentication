using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
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
