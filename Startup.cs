using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWith_Entity.Startup))]
namespace MVCWith_Entity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
