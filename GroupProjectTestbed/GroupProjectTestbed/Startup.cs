using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroupProjectTestbed.Startup))]
namespace GroupProjectTestbed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
