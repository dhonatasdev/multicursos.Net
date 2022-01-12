using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(processo_seletivo.Startup))]
namespace processo_seletivo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
