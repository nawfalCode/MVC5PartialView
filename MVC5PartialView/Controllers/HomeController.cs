using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5PartialView.Controllers
{

   


    public class HomeController : Controller
    {
        public ActionResult ViewwithPartialData()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 

        public ActionResult PartialView()
        {
           using(UsersEntities u=new UsersEntities())
           {
               var v = u.cars.OrderBy(a => a.Id).ToList();
               return PartialView("_partialView", v);
           }
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}