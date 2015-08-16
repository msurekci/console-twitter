using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTwitter.Classes
{
    public class User
    {
        public string Name { get; set; }
        public List<Message> _messages = new List<Message>();
        public List<User> _peopleFollowing = new List<User>(); 
    }
}
