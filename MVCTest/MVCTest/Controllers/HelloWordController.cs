using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class HelloWordController : Controller
    {
        //
        // GET: /HelloWord/
        public ActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int numtimes = 2)
        {
            return HttpUtility.HtmlEncode("Hello" + name + " number of times here: " + numtimes);
            //return "This is your welcome action method";
        }
	}
}