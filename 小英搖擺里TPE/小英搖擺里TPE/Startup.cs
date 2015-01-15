using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(小英搖擺里TPE.Startup))]
namespace 小英搖擺里TPE
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
