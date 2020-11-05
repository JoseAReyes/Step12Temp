using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SinglePage.Models;

namespace SinglePage.Controllers
{
   public class HomeController : Controller
   {
      private readonly ILogger<HomeController> _logger;
      
      [HttpGet]
      public IActionResult Index()
      {
         return View();
      }
      [HttpPost]
      public IActionResult Index(UserResponse g)
      {
         if (ModelState.IsValid)
         {
            return View("Details", g);
         }
         else
         {
            return View(g);
         }
      }

      //UserResponse h = new UserResponse { DateInput = DateTime.Now, Odometer = 15000, Gallons = 22, TotalCost = 22.25M };
      UserResponse[] FirstResponse = FakeDb.GetResponses();

      [HttpGet]
      public IActionResult Edit()
      {
         UserResponse h = new UserResponse { DateInput = DateTime.Now, Odometer = 15000, Gallons = 22, TotalCost = 22.25M };

         return View(h);
      }
      [HttpPost]
      public IActionResult Edit(UserResponse r)
      {
         if (ModelState.IsValid)
         {
            FakeDb.AddResponse(r);
            return View("Details", r);
         }
         else
         {
            return View(r);
         }
      }



      public IActionResult Income()
      {
         return View();
      }
      public IActionResult Expenses()
      {
         return View();
      }
      public IActionResult ShiftLog()
      {
         return View();
      }
   }
}
