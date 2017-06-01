using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Module10_01.Startup))]
namespace Module10_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
