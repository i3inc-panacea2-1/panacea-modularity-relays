using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Relays
{
    public interface IRelayManager
    {
        Task<bool> SetBlindsDownAsync(bool on);

        Task<bool> SetBlindsUpAsync(bool on);

        Task<bool> SetNurseCallAsync(bool on);

    }
}
