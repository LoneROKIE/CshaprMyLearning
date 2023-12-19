using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationBookSample1.Models;

namespace WebApplicationBookSample1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // prueba muestra en la pagina el string
        //public string Index()
        //{
        //    return "Hello Asp.Net Core :)";
        //}
        
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView",viewModel);
        }

        /*
        public IActionResult Index()
        {
            return View();
        }
        */
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
