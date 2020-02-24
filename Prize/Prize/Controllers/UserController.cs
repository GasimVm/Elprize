using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prize.data;
using Prize.Models;
using static Prize.Utilities.SendMesaj;



namespace Prize.Controllers
{
    public class UserController : Controller
    {
        private readonly ElPrizeContext _context;

        public UserController(ElPrizeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            int UserId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value);
            ViewBag.cash = _context.Users.Where(c => c.Id == UserId).First().Cash;
            var model= _context.Users;
            List<UserTranViewModel> list = new List<UserTranViewModel>();
            UserTranViewModel userView =new UserTranViewModel();
            foreach (User item in model)
            {
              var usertarn=_context.Transactions.Where(c => c.SendUserId == item.Id) ;
                double amount = 0;
                foreach (var tr in usertarn)
                {
                    amount += tr.Amount;
                }
                userView = new UserTranViewModel() {

                    Users = item,
                    tranCount = usertarn.Count(),
                    tranDis =( amount / 100)
                };
                list.Add(userView);
            }
             
            return View(list);
        }

        public IActionResult Block(int id)
        {
            _context.Users.Where(c => c.Id == id).First().Acvited = false;
            _context.SaveChanges();
            return Json(new { status = "success", message = "User was blocked", url = Url.Action("Index") });

        }

        public IActionResult BlockUser()
        {
            int UserId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value);
            ViewBag.cash = _context.Users.Where(c => c.Id == UserId).First().Cash;
            var model = _context.Users.Where(c=>c.Acvited==false);
            List<UserTranViewModel> list = new List<UserTranViewModel>();
            UserTranViewModel userView = new UserTranViewModel();
            foreach (User item in model)
            {
                var usertarn = _context.Transactions.Where(c => c.SendUserId == item.Id);
                double amount = 0;
                foreach (var tr in usertarn)
                {
                    amount += tr.Amount;
                }
                userView = new UserTranViewModel()
                {

                    Users = item,
                    tranCount = usertarn.Count(),
                    tranDis = (amount / 100)
                };
                list.Add(userView);
            }

            return View(list);
        }

        public IActionResult UnBlock(int id)
        {
            _context.Users.Where(c => c.Id == id).First().Acvited = true;
            _context.SaveChanges();
            return Json(new { status = "success", message = "User was blocked", url = Url.Action("Index") });

        }

        public IActionResult Online()
        {
            int UserId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value);
            ViewBag.cash = _context.Users.Where(c => c.Id == UserId).First().Cash;
            var modelLog = _context.Logs.Where(c=>c.LogStatus==true && (c.StartDate<DateTime.Now && c.StartDate>DateTime.Now.AddHours(-2))).ToLookup(c=>c.UserId);
            List<UserTranViewModel> list = new List<UserTranViewModel>();
            List<User> listUser = new List<User>();

            UserTranViewModel userView = new UserTranViewModel();
            foreach (var lg in modelLog)
            {
                listUser.Add(lg.First().User);
            }
            foreach (User item in listUser )
            {
                var usertarn = _context.Transactions.Where(c => c.SendUserId == item.Id);
                double amount = 0;
                foreach (var tr in usertarn)
                {
                    amount += tr.Amount;
                }
                userView = new UserTranViewModel()
                {

                    Users = item,
                    tranCount = usertarn.Count(),
                    tranDis = (amount / 100)
                };
                list.Add(userView);
            }

            return View(list);
        }
        public IActionResult Send()
        {
            return View();
        }

        public IActionResult Profile(int userId)
        {
            
            var user=  _context.Users.Where(c => c.Id == userId).First();
            ViewBag.cash = user.Cash;
            ViewBag.Log = _context.Logs.Where(c => c.UserId == userId);
            return View(user);
        }


        public async Task<IActionResult> SendMesssage( string usr)
            {
            int UserId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value);
             
            try
            {
                    var from = new MailAddress("elpircee@gmail.com", "elpirce");
                    var fromPass = "hesen1995";

                    var to = new MailAddress(usr) {
                           
                     };
                    SmtpClient client = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        UseDefaultCredentials = false,

                        EnableSsl = true,
                        Credentials = new NetworkCredential(from.Address, fromPass),

                        DeliveryMethod = SmtpDeliveryMethod.Network
                    };

                    var message = new MailMessage(from, to)
                    {
                        IsBodyHtml = true,
                        Subject = "Elprize",
                        Body = "elpire go ..."
                    };
                var log = new Log()
                {
                    ActionName = "SendMesssage",
                    LogStatus = false,
                    StartDate = DateTime.Now,
                    UserId = UserId

                };
                _context.Logs.Add(log);
                _context.SaveChanges();

                await client.SendMailAsync(message);
                return Json(new { status = "success", message = "User was blocked", url = Url.Action("Index") });


            }
            catch (Exception  )
                {

                return Json(new { status = "error", message = "User was blocked", url = Url.Action("Index") });


            }
        }

           
    }
}