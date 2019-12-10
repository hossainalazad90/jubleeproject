using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SDMJublee.Startup))]
namespace SDMJublee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
