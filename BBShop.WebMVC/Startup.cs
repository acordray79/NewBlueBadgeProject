using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BBShop.WebMVC.Startup))]
namespace BBShop.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
