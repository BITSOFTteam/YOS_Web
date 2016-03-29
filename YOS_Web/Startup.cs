using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YOS_Web.Startup))]
namespace YOS_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
