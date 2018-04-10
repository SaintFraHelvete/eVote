using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eVote.Startup))]
namespace eVote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
