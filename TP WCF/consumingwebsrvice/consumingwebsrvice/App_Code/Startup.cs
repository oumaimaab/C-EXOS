using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(consumingwebsrvice.Startup))]
namespace consumingwebsrvice
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
