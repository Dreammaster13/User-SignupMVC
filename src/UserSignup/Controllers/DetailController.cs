using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserSignup.Models;

namespace UserSignup.Controllers
{
    public class DetailController:Controller
    {
        public IActionResult Index(int id)
        {

           ViewBag.user = UserData.GetUserById(id);
           return View();
            
        }




    }
}
