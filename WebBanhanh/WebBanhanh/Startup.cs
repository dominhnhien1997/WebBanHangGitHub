using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBanhanh.Startup))]
namespace WebBanhanh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
