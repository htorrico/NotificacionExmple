using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(NotificacionExmple.Startup))]
namespace NotificacionExmple
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}