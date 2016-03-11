using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeOA.Controllers
{
    public class SetupController : Controller
    {
        //
        // GET: /Index/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News() {
            return View();
        }

        public ActionResult Product() {
            return View();
        }  

        public ActionResult About() {
            return View();
        } 

        public ActionResult Help() {
            return View();
        }

    }
}
