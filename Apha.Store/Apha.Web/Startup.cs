using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Apha.Web.Startup))]
namespace Apha.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
