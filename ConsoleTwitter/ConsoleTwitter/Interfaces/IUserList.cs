using System.Collections.Generic;
using ConsoleTwitter.Classes;

namespace ConsoleTwitter.Interfaces
{
    public interface IUserList
    {
        void AddUser(string username);

        int CountOfUsers();

        User GetUser(string username);

        List<User> ListOfUsers { get; set; } 
    }
}