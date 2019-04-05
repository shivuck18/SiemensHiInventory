using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.UI.Controllers
{
    public class PlatformController : Controller
    {
        public IActionResult Index()
        {

            ViewData["Message"] = "This is Platform launch page.";
            return View();
        }
    }
}
