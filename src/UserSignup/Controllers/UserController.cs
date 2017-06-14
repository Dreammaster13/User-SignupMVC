using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(List<User> users)
        {
         
            users = UserData.GetAll();
            if (users == null)
            {
                List<User> theUsers = new List<User>();
                return View(theUsers);
            }
            else
            {
                return View(users);
            }
        }

        // TODO 4: add a details controller and view that takes a single userid,
        // gets that user object from UserData, returns it to the details view
        // where it is displayed


        [HttpGet]
        public IActionResult Add()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {

            bool emailVal = UserData.IsValidEmail(user.Email);
            bool unameVal = UserData.IsValidUserName(user.Username);
            if (user.Password == verify && !String.IsNullOrEmpty(user.Password)&&unameVal==true)
            {
                
                List<User> users = UserData.GetAll();
                users.Add(user);
                return RedirectToAction("Index",users);
            }
            else
            {
                ViewBag.PasswordError = user.Password != verify ? "Your passwords must match" : "";
                ViewBag.UsernameError = !unameVal ? "You must enter a valid username (all letters, 5 to 15 characters" : "";
                return View(user);
            }
        }
    }
}
