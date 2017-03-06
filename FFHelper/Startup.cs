using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FFHelper.Startup))]
namespace FFHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
