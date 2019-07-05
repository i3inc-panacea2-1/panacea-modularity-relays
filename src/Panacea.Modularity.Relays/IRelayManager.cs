using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Relays
{
    public interface IRelayManager
    {
        bool BlindsAttached { get; }

        Task<bool> SetBlindsDownAsync(bool on);

        Task<bool> SetBlindsUpAsync(bool on);

        bool NurseCallAttached { get; }

        Task<bool> SetNurseCallAsync(bool on);

    }
}
