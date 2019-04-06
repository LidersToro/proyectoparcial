using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCprueba.Startup))]
namespace MVCprueba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
