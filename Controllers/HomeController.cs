﻿using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjTrashCollection.Models;

namespace TrashCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Redirect("./Identity/Account/Login");
            }
            if (User.IsInRole("Customer"))
            {
                return RedirectToAction("Index", "Customers");
            }
            if (User.IsInRole("Employee"))
            {
                return RedirectToAction("Index", "Employees");
            }
            return RedirectToAction("Index", "Customers");
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