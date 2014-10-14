using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.UI.Areas.TestArea.Controllers
{
    public class AccountController : Controller
    {
        // GET: TestArea/Account
        public ActionResult Index()
        {
            ViewBag.Title = "Success from RedirectAction";
            return View();
        }
    }
}