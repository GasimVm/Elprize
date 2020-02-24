using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Prize.data;
using Prize.Models;

namespace Prize.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ElPrizeContext _context;
        public TransactionController(ElPrizeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            int UserId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value);
            ViewBag.cash = _context.Users.Where(c => c.Id == UserId).First().Cash;
            var model = _context.Transactions.Where(c => c.SendUserId == UserId);
            ViewBag.SendUser = _context.Users.Where(c => c.Id == UserId).First();
            ViewBag.Users = _context.Users.Where(c => c.Id != UserId);
            var log = new Log()
            {
                ActionName = "Tranction/Index",
                LogStatus = false,
                StartDate = DateTime.Now,
                UserId = UserId

            };
            _context.Logs.Add(log);
            _context.SaveChanges();
            return View(model);
        }

        public IActionResult CreateTransaction(int id,double amount,double discount)
        {
            int UserId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value);
            var rm = Guid.NewGuid().ToString("d").Substring(1, 8);
            var trans =new Transaction() {
                 UserId=id,
                 Amount=Convert.ToDouble(amount),
                  SendDate=DateTime.Now,
                    SendUserId= UserId,
                    TransactionNubmer= rm,
                      StatusTransId=1
            };
            _context.Transactions.Add(trans);
           var user= _context.Users.Where(c => c.Id == UserId).First();
            user.Cash -=( amount + discount);
            _context.SaveChanges();

            var log = new Log()
            {
                ActionName = "Tranction/Create",
                LogStatus = false,
                StartDate = DateTime.Now,
                UserId = UserId

            };
            _context.Logs.Add(log);
            _context.SaveChanges();
            return Json(new { status = "success", message = "successful", url = Url.Action("Index") });

        }
    }
    }
