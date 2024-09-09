using MyApp.Models;
using System.Collections.Generic;

namespace MyApp.DAL
{
    // IUserRepository
    // This interface is used to query and save instances of the User class.
    // It is implemented by the UserRepository class in the MyApp.DAL namespace.
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
