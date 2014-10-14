using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.UI.Areas.TestArea.Controllers
{
    public class HomeController : Controller
    {
        // GET: TestArea/Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TestRedirectResult()
        {
            TempData["Title"] = "Coming from RedirectResult";

            var result = new RedirectResult(ActionArea("Success", "Home"));
            return result;
        }

        [HttpGet]
        public ActionResult TestRedirectAction()
        {
            return RedirectToAction("Index", "Account");
        }


        protected string ActionArea(string action, string controller)
        {
            return Url.Action(action, controller);
        }
    }
}