using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTRSYS.Web.Startup))]
namespace MTRSYS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
