using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_AE6.Startup))]
namespace MVC_AE6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
