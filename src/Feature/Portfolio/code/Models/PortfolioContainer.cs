using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;

namespace Agency.Feature.Portfolio.Models
{
    public class PortfolioContainer : SitecoreItem
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        [SitecoreChildren]
        public IEnumerable<PortfolioItem> Children { get; set; }
    }
}