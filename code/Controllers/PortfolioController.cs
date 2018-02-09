﻿using Agency.Feature.Portfolio.Models;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agency.Feature.Portfolio.Controllers
{
    public class PortfolioController : GlassController
    {
        public ActionResult Portfolio()
        {
            var context = new SitecoreContext();
            var portfolioContainer = context.GetItem<PortfolioContainer>("/sitecore/content/Agency/Data/Portfolio Container");
            return View(portfolioContainer);
        }
    }
}