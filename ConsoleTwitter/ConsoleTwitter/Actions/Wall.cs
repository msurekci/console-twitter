using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTwitter.Entities;
using ConsoleTwitter.Interfaces;

namespace ConsoleTwitter.Actions
{
    public class Wall : IWall
    {
        readonly IUserList _userList;

        public Wall(IUserList userList)
        {
            _userList = userList;
        }

        public List<Message> DisplayAllMessages(string username)
        {
            var user = _userList.GetUser(username);
            var usersMessage = user._messages;

            var followedPeopleList = user._peopleFollowing;

            foreach (var people in followedPeopleList)
            {
                usersMessage.AddRange(people._messages);
            }

            return usersMessage;
        }
    }
}
