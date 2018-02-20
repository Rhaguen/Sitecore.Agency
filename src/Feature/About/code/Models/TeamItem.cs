using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;
namespace Agency.Feature.About.Models
{
    public class TeamItem : SitecoreItem
    {
        public string TeamMemberName { get; set; }
        public string Position { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public Image Image { get; set; }
    }
}