using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JasmineTests.Startup))]
namespace JasmineTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
