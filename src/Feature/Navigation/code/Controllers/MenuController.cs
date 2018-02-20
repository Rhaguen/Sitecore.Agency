using Agency.Feature.Navigation.Models;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.Navigation.Controllers
{
    public class MenuController : GlassController
    {
        // GET: Menu
        public ActionResult MainMenu()
        {
            var context = new SitecoreContext();
            var mainMenu = context.GetItem<MainMenu>("/sitecore/content/Agency/Data/Main Menu");

            return View(mainMenu);
        }
    }
}