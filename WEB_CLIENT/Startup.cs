using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEB_CLIENT.Startup))]
namespace WEB_CLIENT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
