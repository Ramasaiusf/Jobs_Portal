using Jobs_Portal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Jobs_Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger) => _logger = logger;



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            // This action corresponds to "AboutUs.html"
            return View();
        }

        public IActionResult Departments()
        {
            // This action corresponds to "Departments.html"
            return View();
        }
        public IActionResult JobPostings()
        {           
            return View();
        }

        public IActionResult JobStats()
        {
            
            return View();
        }
        public IActionResult SignUp()
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