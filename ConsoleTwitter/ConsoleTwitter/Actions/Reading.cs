using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTwitter.Entities;
using ConsoleTwitter.Interfaces;

namespace ConsoleTwitter.Actions
{
    public class Reading : IReading
    {
        readonly IUserList _userList;

        public Reading(IUserList userList)
        {
            _userList = userList;
        }

        public List<Message> GetMessages(string username)
        {
            var user = _userList.GetUser(username);
            return user._messages;
        }
    }
}
