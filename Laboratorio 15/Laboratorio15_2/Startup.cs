using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Laboratorio152.Startup))]

namespace Laboratorio152
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                return context.Response.WriteAsync("Hello World desde Laboratorio 15-2!");
            });
        }
    }
}
