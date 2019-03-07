using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DASHBOARD.Startup))]
namespace DASHBOARD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
