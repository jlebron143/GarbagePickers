using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GarbagePickers.Startup))]
namespace GarbagePickers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
