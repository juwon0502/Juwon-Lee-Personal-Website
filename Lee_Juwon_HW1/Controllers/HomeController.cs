using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lee_Juwon_HW1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult personal()
        {
            return View();
        }
        public IActionResult cooking()
        {
            return View();
        }
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult resume()
        {
            string path = _environment.WebRootPath + "/files/Juwon Lee Resume.pdf";            
            var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var fsResult = new FileStreamResult(stream, "application/pdf");
            return fsResult;
        }
    }
}
