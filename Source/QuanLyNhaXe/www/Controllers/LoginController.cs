using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using www.Models;

namespace www.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(Users.Login login)
        {
            if (ModelState.IsValid)
            {
                if (Users.Login.IsValid(login.username_, login.password_))
                {
                    FormsAuthentication.SetAuthCookie(login.username_, login.RememberMe);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Message = "Tài khoản hoặc mật khẩu không đúng !";
                    ViewBag.Alert = "alert-danger";
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }                        
            return View();            
        }
    }
}
