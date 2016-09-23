using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sistema1.Startup))]
namespace sistema1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
