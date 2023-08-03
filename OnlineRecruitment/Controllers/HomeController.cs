using OnlineRecruitment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineRecruitment.Controllers
{
    public class HomeController : Controller

    { 
         private recruitmentEntities1 db = new recruitmentEntities1();

    public ActionResult Index()
        {
            return View();
        }
        public ActionResult JobDescription()
        {

            return View();
        }
        public ActionResult Status()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
        public ActionResult Signup()
        {
            return RedirectToAction("Create", "Logins");
        }
        public ActionResult Signout()
        {
            return RedirectToAction("Index");
        }
        public ActionResult selected_students()
        {
            return View(db.Students.ToList());
        }

    }
}
