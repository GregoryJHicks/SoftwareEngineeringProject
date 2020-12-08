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

        public IActionResult Index()
        {
            List<MenuItem> List = LoadJson();
            return View(List);
        }

        // Would handle processing of the payment
        public IActionResult PaymentProcessing(string name, string address, string cardNumber, string experationDate, string securityCode) 
        {
            Order temp = new Order();
            temp.ProcessOrder(name, address, cardNumber, experationDate, securityCode);
            AllOrders.Add(temp);
            return RedirectToAction("Receipt", "Home");
        }

        //loads the checkout page
        public IActionResult Checkout()
        {
            return View();
        }

        //loads the reciept page
        public IActionResult Receipt()
        {
            return View(AllOrders.Last());
        }

        //loads the cart page
        public IActionResult CartView()
        {
            return View(Cart.Contents);
        }

        //loads the past orders page
        public IActionResult Orders()
        {
            return View(AllOrders.Orders);
        }

        //adds an item to the cart
        public IActionResult Add(int Id)
        {
            List<MenuItem> tempMenu = LoadJson();
            var item = tempMenu.Find(delegate (MenuItem item) { return item.food_id == Id; });
            Models.Cart.AddToCart(item);
            return RedirectToAction("Index", "Home");
        }

        //loads the json menu list into a list
        public List<MenuItem> LoadJson()
        {
            using (StreamReader s = new StreamReader("menu.json"))
            {
                string json = s.ReadToEnd();
                List<MenuItem> items = JsonConvert.DeserializeObject<List<MenuItem>>(json);
                return items;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
