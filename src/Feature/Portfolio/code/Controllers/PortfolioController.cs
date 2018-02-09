using Agency.Feature.Portfolio.Models;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.Portfolio.Controllers
{
    public class PortfolioController : GlassController
    {
        public ActionResult Portfolio()
        {
            var context = new SitecoreContext();
            var portfolioContainer = context.GetItem<PortfolioContainer>("/sitecore/content/Agency/Data/Portfolio Container");
            string viewName = Sitecore.Context.PageMode.IsExperienceEditor ? "PortfolioEditMode" : "Portfolio";
            return View(viewName, portfolioContainer);
        }
    }
}