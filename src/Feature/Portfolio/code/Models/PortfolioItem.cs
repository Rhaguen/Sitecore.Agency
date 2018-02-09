using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;
using System;

namespace Agency.Feature.Portfolio.Models
{
    public class PortfolioItem : SitecoreItem
    {
        public string Client { get; set; }
        public string Category { get; set; }
        public Image Image { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Link Thumbnail { get; set; }
        public string ProjectName { get; set; }
        public string ProjectTitle { get; set; }
    }
}