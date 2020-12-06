using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SoftwareEngineeringProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.IO;

namespace SoftwareEngineeringProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //View section: it contains all of the actions that run each page
        public IActionResult Index()
        {
            MenuItem temp1 = new MenuItem();
            MenuItem temp2 = new MenuItem();
            List<MenuItem> Random = new List<MenuItem> { temp1, temp2 };
            return View(Random);
        }

        public IActionResult Payment()
        {
            return View();
        }

        public IActionResult Reciept()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }

        public void LoadJson()
        {
            using (StreamReader s = new StreamReader("menu.json"))
            {
                string json = s.ReadToEnd();
                List<MenuItem> items = JsonConvert.DeserializeObject<List<MenuItem>>(json);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
