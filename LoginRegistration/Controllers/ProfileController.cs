using LoginRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginRegistration.Controllers
{
    public class ProfileController : Controller
    {
        Model dbo = new Model();

        // GET: Profile
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                int userId = (int)Session["UserID"];

                var user = dbo.Users.Where(u => u.ID == userId).Single();

                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
    }
}