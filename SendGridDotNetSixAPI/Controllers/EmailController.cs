using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SendGridDotNetSixAPI.Controllers
{
    [Authorize]
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            Debug.WriteLine("test TEXT");
            return View();
        }
    }
}
