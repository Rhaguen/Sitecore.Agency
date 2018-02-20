using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency.Feature.Navigation.Models
{
    public class PartnerContainer : SitecoreItem
    {
        [SitecoreChildren]
        public IEnumerable<PartnerItem> Children { get; set; }
    }
}