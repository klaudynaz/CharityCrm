using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CharityCrm.Startup))]
namespace CharityCrm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
