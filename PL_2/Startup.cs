using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PL_2.Startup))]
namespace PL_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
