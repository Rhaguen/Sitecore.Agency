using Agency.Feature.About.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.About.Controllers
{
    public class AboutController : GlassController
    {
        public ActionResult About()
        {
            var aboutContainer = this.GetDataSourceItem<AboutContainer>();
            return View(Sitecore.Context.PageMode.IsExperienceEditor ? "AboutEditMode" : "About", aboutContainer);
        }

        public ActionResult AboutItem()
        {
            bool position = TempData["inverted"] != null ? bool.Parse(TempData["inverted"].ToString()) : false;
            var aboutItem = this.GetDataSourceItem<AboutItem>();
            aboutItem.Inverted = position;
            TempData["inverted"] = !position;
            return View(Sitecore.Context.PageMode.IsExperienceEditor ? "AboutItemEditMode" : "AboutItem", aboutItem);
        }
    }
}