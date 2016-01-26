using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NrthWndService.Startup))]
namespace NrthWndService
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
