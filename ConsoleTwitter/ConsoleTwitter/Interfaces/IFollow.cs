using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTwitter.Interfaces
{
    public interface IFollow
    {
        void FollowUser(string username, string usernameOfFollowed);
    }
}
