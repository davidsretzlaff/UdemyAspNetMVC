using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(learnaspnet.Startup))]
namespace learnaspnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
