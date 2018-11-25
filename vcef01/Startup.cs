using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vcef01.Startup))]
namespace vcef01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
