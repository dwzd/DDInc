using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DDInc.Startup))]
namespace DDInc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
