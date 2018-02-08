using Agency.Feature.Services.Models;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.Services.Controllers
{
    public class ServicesController : GlassController
    {
        public ActionResult ServiceContainer()
        {
            var context = new SitecoreContext();
            var serviceContainer = context.GetItem<ServicesContainer>("/sitecore/content/Agency/Data/Services Container");

            return View(serviceContainer);
        }
    }
}