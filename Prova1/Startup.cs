using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prova1.Startup))]
namespace Prova1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
