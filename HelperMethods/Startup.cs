using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelperMethods.Startup))]
namespace HelperMethods
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
