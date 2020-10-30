using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lap4.Startup))]
namespace Lap4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
