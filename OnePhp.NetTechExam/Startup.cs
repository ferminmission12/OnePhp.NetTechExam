using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnePhp.NetTechExam.Startup))]
namespace OnePhp.NetTechExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
