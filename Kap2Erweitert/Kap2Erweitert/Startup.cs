using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kap2Erweitert.Startup))]
namespace Kap2Erweitert
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
