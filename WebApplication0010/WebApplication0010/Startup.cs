using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication0010.Startup))]
namespace WebApplication0010
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
