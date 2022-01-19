using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    interface IWalkAway //naming conventions for interfaces begin with "I" (ex: "ILimitPurchase", "IEndSession")
    // .NET Framework does not support multiple inheritance otherwise
    // .NET Framework supports multiple inheritance with INTERFACE: inherit a base class, then inherit many interfaces
    // No implementation details with Interface (similar) to abstract
    // Everything is public in interface, dont need to state public
    {
        void WalkAway(Player player);
    }
}
