using System.Collections.Generic;
using ConsoleTwitter.Classes;
using ConsoleTwitter.Interfaces;

namespace ConsoleTwitter
{
    public class UserList : IUserList
    {
        private List<User> userList = new List<User>()
                                      {
                                          new User()
                                          {
                                              Name = "Mahmut",
                                              _messages = new List<Message>()
                                                          {
                                                              new Message()
                                                              {
                                                                  UsersMessage = "Ye, it kind of works"
                                                              }
                                                          }
                                          }
                                      };

        public List<User> ListOfUsers { 
        get
        {
            return userList;
        }
            set
            {
                userList = value;
            } 
        }

        public void AddUser(string username)
        {
            userList.Add(new User()
                         {
                             Name = username,
                             _messages = new List<Message>()
                         });
        }

        public int CountOfUsers()
        {
            return userList.Count;
        }

        public User GetUser(string username)
        {
            var user = this.userList.Find(u => u.Name == username);
            return user;
        }
    }
}