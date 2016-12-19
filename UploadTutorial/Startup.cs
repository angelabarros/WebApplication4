using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UploadTutorial.Startup))]
namespace UploadTutorial
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
