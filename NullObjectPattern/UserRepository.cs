using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    // In-memory storage keeps this example focused on the Null Object pattern.
    // Tech debt: production code should use database persistence through an ORM or DAO.
    public class UserRepository : IUserRepository
    {
        // Seed this repository instance with sample users.
        public UserRepository()
        {
            users = new List<User>
            {
                new User(Guid.Parse("00000000-0000-0000-0000-000000000001"), "Bob"),
                new User(Guid.Parse("00000000-0000-0000-0000-000000000002"), "Henry"),
                new User(Guid.Parse("00000000-0000-0000-0000-000000000003"), "Charles"),
                new User(Guid.Parse("00000000-0000-0000-0000-000000000004"), "Rothbard")
            };
        }

        // Return a NullUser when the requested ID is not found.
        public IUser GetByID(Guid userID)
        {
            IUser userFound = users.SingleOrDefault(user => user.ID == userID);
            if(userFound == null)
            {
                userFound = new NullUser();
            }
            return userFound;
        }

        private ICollection<User> users;
    }
}
