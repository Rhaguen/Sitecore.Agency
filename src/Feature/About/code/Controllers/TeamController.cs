using Agency.Feature.About.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.About.Controllers
{
    public class TeamController : GlassController
    {
        public ActionResult Team()
        {
            var teamContainer = this.GetDataSourceItem<TeamContainer>();
            return View(Sitecore.Context.PageMode.IsExperienceEditor ? "TeamEditMode" : "Team", teamContainer);
        }

        public ActionResult TeamItem()
        {
            var teamItem = this.GetDataSourceItem<TeamItem>();
            return View(Sitecore.Context.PageMode.IsExperienceEditor ? "TeamItemEditMode" : "TeamItem", teamItem);
        }
    }
}