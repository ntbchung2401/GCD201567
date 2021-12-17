using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GCD201567.Startup))]
namespace GCD201567
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
