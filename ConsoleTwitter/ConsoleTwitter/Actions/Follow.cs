using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTwitter.Interfaces;

namespace ConsoleTwitter.Actions
{
    public class Follow : IFollow
    {
        readonly IUserList _userList;

        public Follow(IUserList userList)
        {
            _userList = userList;
        }

        public void FollowUser(string username, string usernameOfFollowed)
        {
            var user = _userList.GetUser(username);

            var userToFollow = _userList.GetUser(usernameOfFollowed);

            user._peopleFollowing.Add(userToFollow);

        }
    }
}
