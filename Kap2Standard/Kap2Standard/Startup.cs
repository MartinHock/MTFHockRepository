using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kap2Standard.Startup))]
namespace Kap2Standard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
