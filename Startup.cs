using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiValVending.Startup))]
namespace DiValVending
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
