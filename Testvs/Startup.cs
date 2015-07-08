using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testvs.Startup))]
namespace Testvs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
