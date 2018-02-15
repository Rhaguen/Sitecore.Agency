using Agency.Feature.Portfolio.Models;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System.Linq;
using System.Web.Mvc;

namespace Agency.Feature.Portfolio.Controllers
{
    public class PortfolioController : GlassController
    {
        public ActionResult Portfolio()
        {
            var portfolioContainer = this.GetDataSourceItem<PortfolioContainer>();
            return View(Sitecore.Context.PageMode.IsExperienceEditor ? "PortfolioEditMode" : "Portfolio", portfolioContainer);
        }

        public ActionResult PortfolioItem()
        {
            var portfolioItem = this.GetDataSourceItem<PortfolioItem>();
            return View(Sitecore.Context.PageMode.IsExperienceEditor ? "PortfolioItemEditMode" : "PortfolioItem", portfolioItem);
        }
    }
}