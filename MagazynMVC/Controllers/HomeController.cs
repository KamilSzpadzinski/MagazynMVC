using MagazynMVC.Interfaces;
using MagazynMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MagazynMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOilService _oilService;

        public HomeController(ILogger<HomeController> logger, IOilService oilService)
        {
            _logger = logger;
            _oilService = oilService;
        }

        public IActionResult Index()
        {
            var oils = _oilService.GetOils();

            ViewBag.Oils = oils;
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