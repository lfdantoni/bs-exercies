using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserControl.Startup))]
namespace UserControl
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
