using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    /// <summary>
    /// Represents a real user with an identity and session state.
    /// </summary>
    public class User : IUser
    {
        /// Creates a user and initializes their identity and session state.
        /// <param name="id">The user's unique identifier.</param>
        /// <param name="name">The user's display name.</param>
        public User(Guid id, string name)
        {
            ID = id;
            Name = name;
            sessionExpiry = DateTime.Now;
            IncrementSessionTicket();
        }

        /// Gets the user's unique identifier.
        public Guid ID
        {
            get;
            private set;
        }

        /// Gets the user's display name.
        public string Name
        {
            get;
            private set;
        }

        public void IncrementSessionTicket()
        {
            sessionExpiry = sessionExpiry.AddMinutes(30);
        }

        /// Indicates whether this instance represents a missing user.
        public bool IsNull
        {
            get
            {
                return false;
            }
        }

        private DateTime sessionExpiry;
    }
}
