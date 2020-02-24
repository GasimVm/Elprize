using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prize.data;
using Prize.Models;

namespace Prize.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ElPrizeContext _context;

        public HomeController(ElPrizeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
             
            int UserId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value);
            ViewBag.cash = _context.Users.Where(c => c.Id == UserId).First().Cash;
            var log = new Log()
            {
                ActionName = "Home/Index",
                LogStatus = false,
                StartDate = DateTime.Now,
                UserId = UserId

            };
            _context.Logs.Add(log);
            _context.SaveChanges();
            return View();
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
