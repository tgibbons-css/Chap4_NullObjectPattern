using NullObjectPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    class Program
    {
        static IUserRepository userRepository = new UserRepository();

        static void Main(string[] args)
        {
            Console.WriteLine("Null Object Pattern: handling found and missing users");
            Console.WriteLine();

            Console.WriteLine("Example 1: The repository finds a real user.");
            // This ID matches Bob in the in-memory repository.
            IUser foundUser = userRepository.GetByID(
                Guid.Parse("00000000-0000-0000-0000-000000000001"));
            foundUser.IncrementSessionTicket();
            Console.WriteLine("Name: {0}", foundUser.Name);
            Console.WriteLine("The caller uses the IUser interface, not the concrete User class.");
            Console.WriteLine();

            Console.WriteLine("Example 2: The repository cannot find a matching user.");
            // Guid.Empty is not assigned to any sample user, so the repository returns NullUser.
            IUser missingUser = userRepository.GetByID(Guid.Empty);
            missingUser.IncrementSessionTicket();
            Console.WriteLine("Name: {0}", missingUser.Name);
            Console.WriteLine("NullUser safely handles the call without a null check.");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
