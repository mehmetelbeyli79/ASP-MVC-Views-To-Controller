using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult HomePage()
        {
            return View();
        }

        // POST: Home
        [HttpPost]
        public ActionResult HomePage(string text1, bool check1, string list1)
        {
            var t1 = Request.Form["text1"];
            var l1 = Request.Form["list1"];
            var c1 = Request.Form.GetValues("check1")[0];
            return View();
        }
    }
}