using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzashops.Models;
namespace Pizzashops.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult Autherize(User userModel)
        {
            using (LoginDataBaseEntities db = new LoginDataBaseEntities())
            {
                var UserDetails = db.Users.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
                if (UserDetails == null)
                {
                    userModel.LoginErrorMessage = "Wrong UserName or Password!!!";
                    return View("Index", userModel);
                }
                else
                {
                    Session["userId"] = userModel.UserID;
                    Session["username"] = userModel.UserName;
                    return RedirectToAction("Display", "Pizzas");
                }
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}