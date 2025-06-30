using lesson11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lesson11.Controllers
{
    public class NhnHomeController : Controller
    {
        private readonly ILogger<NhnHomeController> _logger;

        public NhnHomeController(ILogger<NhnHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
