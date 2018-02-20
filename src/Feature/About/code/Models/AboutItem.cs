using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.About.Models
{
    public class AboutItem : SitecoreItem
    {
        public string TimeSpan { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Image Image { get; set; }
        public bool Inverted { get; internal set; }
    }
}