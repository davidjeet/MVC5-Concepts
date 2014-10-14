using System.Web.Mvc;

namespace Web.UI.Areas.TestArea
{
    public class TestAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TestArea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Default2",
                "TestArea/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "Web.UI.Areas.TestArea.Controllers" }
            );
        }
    }
}