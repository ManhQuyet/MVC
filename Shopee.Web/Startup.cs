using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shopee.Web.Startup))]
namespace Shopee.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
