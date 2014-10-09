using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PC.RMS.RP.Areas.SelfService.Controllers
{
    using Web.UI.Infrastructure.Alerts;

    public class TestAlertsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string id = "abc")
        {
            //Url.ActionArea()
            return RedirectToAction("Index").WithWarning(id);
        }
    }
}