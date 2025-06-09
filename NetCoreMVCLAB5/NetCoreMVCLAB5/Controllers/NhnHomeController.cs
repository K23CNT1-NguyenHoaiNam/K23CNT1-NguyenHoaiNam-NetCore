using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLAB5.Models;
using System.Diagnostics;

namespace NetCoreMVCLAB5.Controllers
{
    public class NhnHomeController : Controller
    {
        private readonly ILogger<NhnHomeController> _logger;

        public NhnHomeController(ILogger<NhnHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NhnIndex()
        {
            return View("NhnIndex");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
