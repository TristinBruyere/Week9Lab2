using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MortgageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPage()
        {
            ViewData["FirstName"] = "Tristin";
            ViewData["LastName"] = "Bruyere";
            return View();
        }

        public IActionResult SignupForm()
        {
            return View();
        }

        public IActionResult Done(string firstname, string lastname, string password)
        {
            ViewData["FirstName"] = firstname;
            ViewData["LastName"] = lastname;
            ViewData["Password"] = password;
            return View();
        }

        public IActionResult UserContactForm()
        {
            return View();
        }

        public IActionResult ThankYou(UserContact user)
        {
            return View(user);
        }

        public IActionResult Links()
        {
            return View();
        }
    }
}
