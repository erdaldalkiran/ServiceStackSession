using Funq;
using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.Caching;
using Web.Model;
using Web.Service;

namespace Web
{
    public class ProteinTrackerAppHost : AppHostBase
    {
        public ProteinTrackerAppHost()
            : base("Protein Tracker", typeof(EntryService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            Plugins.Add(new SessionFeature());

            container.Register<ICacheClient>(new MemoryCacheClient());
        }
    }
}