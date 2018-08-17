using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kap2Asynchron.Startup))]
namespace Kap2Asynchron
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
