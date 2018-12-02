using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CenterSite.Startup))]
namespace CenterSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
