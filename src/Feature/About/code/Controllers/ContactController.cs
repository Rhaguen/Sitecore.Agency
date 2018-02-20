using Agency.Feature.About.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.About.Controllers
{
    public class ContactController : GlassController
    {
        public ActionResult Contact()
        {
            var contactContainer = this.GetDataSourceItem<ContactUs>();
            return View(Sitecore.Context.PageMode.IsExperienceEditor ? "ContactEditMode" : "Contact", contactContainer);
        }

        [HttpPost]
        public JsonResult EditContact(ContactForm contactForm) => Json(new { status = "OK" });
    }
}