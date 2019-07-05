using Panacea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Relays
{
    public static class PanaceaServicesExtensions
    {
        public static bool GetRelayManager(this PanaceaServices core, out IRelayManager relay)
        {
            relay = core.PluginLoader.GetPlugins<IRelayManagerPlugin>().FirstOrDefault()?.GetRelayManager();
            return relay != null;
        }
    }
}
