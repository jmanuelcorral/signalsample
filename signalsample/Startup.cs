using Microsoft.Owin;
using Owin;
using signalsample;

namespace signalsample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
