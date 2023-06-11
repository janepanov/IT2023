using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoService.Startup))]
namespace AutoService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
