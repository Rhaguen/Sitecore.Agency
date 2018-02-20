using Agency.Feature.Navigation.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.Navigation.Controllers
{
    public class PartnerController : GlassController
    {
        public ActionResult Partner()
        {
            return View();
        }

        public ActionResult PartnerItem()
        {
            var partner = this.GetDataSourceItem<PartnerItem>();
            return View(partner);
        }
    }
}