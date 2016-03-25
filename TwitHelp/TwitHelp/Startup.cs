using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwitHelp.Startup))]
namespace TwitHelp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
