﻿using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;
using System;

namespace Agency.Feature.Portfolio.Models
{
    public class PortfolioItem : SitecoreItem
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public Image Image { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Link Thumbnail { get; set; }
    }
}