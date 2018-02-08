using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System.ComponentModel.Design;
using System.Web.Mvc;

namespace Agency.Feature.Services.Controllers
{
    public class ServicesController : GlassController
    {
        public ActionResult Service()
        {
            var context = new SitecoreContext();
            var mainMenu = context.GetItem<ServiceContainer>("/sitecore/content/Agency/Data/Services Container");

            return View(mainMenu);
        }
    }
}