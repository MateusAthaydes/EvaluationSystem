using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EvaluationSystem.Startup))]
namespace EvaluationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
