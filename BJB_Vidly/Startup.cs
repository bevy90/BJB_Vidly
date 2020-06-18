using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BJB_Vidly.Startup))]
namespace BJB_Vidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
