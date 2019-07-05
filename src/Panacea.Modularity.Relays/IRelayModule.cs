using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Relays
{
    public interface IRelayModule
    {
        Task<bool> SetStatusAsync(bool on, int port);
    }
}
