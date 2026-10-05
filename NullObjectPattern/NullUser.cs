using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    /// <summary>
    /// Represents a missing user so callers can use IUser without null checks.
    /// </summary>
    public class NullUser : IUser
    {
        public void IncrementSessionTicket()
        {
            // The null object safely ignores operations that need a real user.
        }

        public string Name
        {
            get
            {
                return "unknown";
            }
        }
    }
}
