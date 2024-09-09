using MyApp.Models;
using System.Collections.Generic;

namespace MyApp.Services
{
    // IUserService
    // This interface is used to query and save instances of the User class.
    // It is implemented by the UserService class in the MyApp.Services namespace.
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
