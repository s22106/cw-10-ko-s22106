using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace cw_10_ko_s22106.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTime "] = numTimes;

            return View();
        }
    }
}