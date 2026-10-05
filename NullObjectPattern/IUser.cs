using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    // Shared contract lets callers use real users and NullUser without null checks.
    public interface IUser
    {
        // Real users extend their session; NullUser safely does nothing.
        void IncrementSessionTicket();

        // Supplies a display name; NullUser provides fallback text.
        string Name
        {
            get;
        }
    }
}
