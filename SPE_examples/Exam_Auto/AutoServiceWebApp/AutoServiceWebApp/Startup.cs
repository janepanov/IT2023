using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoServiceWebApp.Startup))]
namespace AutoServiceWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
