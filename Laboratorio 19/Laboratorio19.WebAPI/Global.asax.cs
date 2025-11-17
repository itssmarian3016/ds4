using System.Web;
using System.Web.Http;

namespace Laboratorio19.WebAPI
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
