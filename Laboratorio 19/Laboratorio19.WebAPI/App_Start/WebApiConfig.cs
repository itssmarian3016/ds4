using System.Web.Http;

namespace Laboratorio19.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Force JSON responses
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
