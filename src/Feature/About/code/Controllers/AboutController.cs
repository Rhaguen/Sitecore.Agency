using Agency.Feature.About.Models;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.About.Controllers
{
    public class AboutController : GlassController
    {
        public ActionResult About()
        {
            var context = new SitecoreContext();
            var aboutContainer = context.GetItem<AboutContainer>("/sitecore/content/Agency/Home/Page Data/About Container");
            string viewName = Sitecore.Context.PageMode.IsExperienceEditor ? "AboutContainerEditMode" : "AboutContainer";
            return View(viewName, aboutContainer);
        }
    }
}