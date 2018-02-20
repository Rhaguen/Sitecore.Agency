using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.Navigation.Models
{
    public class PartnerItem : SitecoreItem
    {
        //[SitecoreField("Imagem")]
        public Image Image { get; set; }
        public string Title { get; set; }
    }
}