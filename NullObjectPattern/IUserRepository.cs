using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    // Separates user lookup from how and where user data is stored.
    public interface IUserRepository
    {
        // Finds a user by ID; this example returns NullUser when no match exists.
        IUser GetByID(Guid userID);
    }
}
