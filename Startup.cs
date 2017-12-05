using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoxWi.Db.Sample.Startup))]
namespace HoxWi.Db.Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
