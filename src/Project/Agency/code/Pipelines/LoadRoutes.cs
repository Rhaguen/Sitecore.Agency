namespace Sitecore.Habitat.Website.Pipelines
{
    using Sitecore.Diagnostics;
    using Sitecore.Pipelines;
    using System.Web.Mvc;
    using System.Web.Routing;

    // TODO: \App_Config\include\LoadRoutes.config created automatically when creating LoadRoutes class.

    public class LoadRoutes
    {
        public void Process(PipelineArgs args)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        private static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                name: "EditContact",
                url: "{Contact}/{EditContact}/{contactForm}",
                defaults: new { controller = "Contact", action = "EditContact", contactForm = UrlParameter.Optional }
            );
        }
    }
}