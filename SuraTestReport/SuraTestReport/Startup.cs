using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuraTestReport.Startup))]
namespace SuraTestReport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
