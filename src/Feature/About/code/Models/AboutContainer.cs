using Agency.Foundation.Orm.Models;
using System.Collections.Generic;

namespace Agency.Feature.About.Models
{
    public class AboutContainer : SitecoreItem
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public IEnumerable<AboutItem> Children { get; set; }
    }
}