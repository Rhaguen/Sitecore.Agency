using Agency.Foundation.Orm.Models;
using System.Collections.Generic;

namespace Agency.Feature.Services.Models
{
    public class ServicesContainer : SitecoreItem
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public IEnumerable<ServiceItem> Children { get; set; }
    }
}