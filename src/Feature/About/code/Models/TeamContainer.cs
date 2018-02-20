using Agency.Foundation.Orm.Models;
using System.Collections.Generic;
namespace Agency.Feature.About.Models
{
    public class TeamContainer : SitecoreItem
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public IEnumerable<TeamItem> Children { get; set; }
    }
}