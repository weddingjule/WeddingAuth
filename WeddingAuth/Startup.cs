using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeddingAuth.Startup))]
namespace WeddingAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
