using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inventory.UI.Models;

namespace Inventory.UI.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// function to return view  for index
        /// </summary>

        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// function for add 
        /// </summary>

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        /// <summary>
        /// function to return view  for contact
        /// </summary>
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /// <summary>
        /// function to return view  for Privacy
        /// </summary>
        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        /// <summary>
        /// function to return view  for error
        /// </summary>
        public IActionResult Error()
        {
            return View();
        }
    }
}
