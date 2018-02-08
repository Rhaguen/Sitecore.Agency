using Agency.Foundation.Orm.Models;

namespace Agency.Feature.Services.Models
{
    public class ServiceItem : SitecoreItem
    {
        public string IconType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}