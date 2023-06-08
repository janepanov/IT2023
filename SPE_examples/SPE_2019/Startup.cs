using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITLab3_groupA.Startup))]
namespace ITLab3_groupA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
