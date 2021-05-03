using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RRater.Startup))]
namespace RRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
