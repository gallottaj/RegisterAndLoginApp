using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegisterAndLoginApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        //public item
        //accept a user model and send it as a parameter to the next view
        public IActionResult ProcessLogin(UserModel userModel)
        {
            if (userModel.UserName == "BillGates" && userModel.Password == "bigbucks")
            {
                return View("LoginSuccess", userModel);

            }
            else
            {
                return View("LoginSuccess", userModel);

            }
        }
    }
}
