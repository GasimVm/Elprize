using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Prize.data;
using Prize.Models;
using Prize.Servicies;

namespace Tend.Controllers
{
    public class AccountController : Controller
    {
        private readonly ElPrizeContext _context;
        private readonly IUserService _userServiece;
        public AccountController(ElPrizeContext context, IUserService userService)
        {
            _context = context;
            _userServiece = userService;
        }
        // GET: Accunt
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.ErrorMessage = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                User user = await _userServiece.Authenticate(model);
                if (user.Email == null)
                {
                    ViewBag.ErrorMessage = "İstifadəçi adı və ya şifrə yanlışdır.";
                    return View(model);
                }
                return await SignInUser(user);
            }
            catch (Exception ex)
            {
                var mes = ex.Message;
                return Content("İstifadəçi adı və ya şifrə yanlışdır.");
            }
        }

        public ActionResult Register()
        {
            ViewBag.Countries = _context.Set<Country>().AsQueryable().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            });

            return View();
        }
        [HttpPost]
        public ActionResult Register( RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                 
                return Json(new { message = "Form not valid" });
            }
            if (  _context.Users.Where(c=>c.Username==model.Username).Count() == 0)
            {
                if (model.Password.Trim() == model.ConfirmPassword.Trim())
                {

                    var user = new User
                    {
                        Firstame = model.Firstname,
                        Lastname = model.Lastname,
                        CountryId = model.CountryId,
                        Password = model.Password,
                        Cash = 1000,
                        Email = model.Email,
                        Username = model.Username,
                        PhoneNumber = model.PhoneNumber,
                        Acvited = true,
                        RoleId = 1,
                        Role = _context.Roles.Where(c => c.Id == 1).First()
                    };

                    _context.Users.Add(user);

                    _context.SaveChanges();
                    
                    var userDb = _context.Users.Where(c => c.Username == model.Username).First();
                    SignInUser(userDb);

                    return Ok(new { href = "/Home/Index" });
                }
                
                return Json(new
                {
                    message = "password and confirm password not matched"
                });
            }
            
            return Json(new
            {
                message = "this username already  taken"
            });
        }
        private async Task<IActionResult> SignInUser(User user)
        {
            try
            {
                List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Role,user.Role.Name),
                new Claim(ClaimTypes.Surname,user.Lastname),
                 new Claim(ClaimTypes.Email,user.Email),
                 new Claim(ClaimTypes.HomePhone,user.Cash.ToString()),

                new Claim(ClaimTypes.Name,user.Firstame),
                new Claim(ClaimTypes.PrimarySid,user.Id.ToString())
            };
                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
                Thread.CurrentPrincipal = principal;
                var log = new Log()
                {
                    ActionName = "Login",
                     LogStatus=true,
                      StartDate=DateTime.Now,
                       UserId=user.Id

                };
                _context.Logs.Add(log);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult AccessDenied(LoginViewModel model)
        {
            return Json("access denied");
        }
        public async Task<IActionResult> LogOut()
        {
            int UserId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value);

            await HttpContext.SignOutAsync();
            var log = new Log()
            {
                ActionName = "Login",
                LogStatus = false,
                StartDate = DateTime.Now,
                UserId = UserId

            };
            _context.Logs.Add(log);
            _context.SaveChanges();
           return RedirectToAction("Login", "Account");
        }
    }
}