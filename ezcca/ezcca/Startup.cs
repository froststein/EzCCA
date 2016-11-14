using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ezcca.Startup))]
namespace ezcca
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
