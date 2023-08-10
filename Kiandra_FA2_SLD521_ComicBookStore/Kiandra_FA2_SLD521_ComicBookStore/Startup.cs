using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kiandra_FA2_SLD521_ComicBookStore.Startup))]
namespace Kiandra_FA2_SLD521_ComicBookStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
