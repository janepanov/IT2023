using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AbsenceWebApp.Startup))]
namespace AbsenceWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
