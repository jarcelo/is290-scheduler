using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace is290_scheduler.ASPCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        // for test.html
        public IActionResult test()
        {
            ViewData["Message"] = "test page";

            return View();
        }


        // for NewTest
        public IActionResult newtest()
        {
            ViewData["Message"] = "new test page";

            return View();
        }

        // for Calendar
        public IActionResult calendar()
        {
            ViewData["Message"] = "Calendar";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
