using LoginRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginRegistration.Controllers
{
    public class RegisterController : Controller
    {
        UsersEntities dbo = new UsersEntities();

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult SaveData(User model)
        {
            dbo.Users.Add(model);
            dbo.SaveChanges();

            return Json("Registration Successfull", JsonRequestBehavior.AllowGet);
           
        }
    }
}