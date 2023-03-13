using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hoangvu.Startup))]
namespace hoangvu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
