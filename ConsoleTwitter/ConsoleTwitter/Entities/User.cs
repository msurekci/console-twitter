using System.Collections.Generic;

namespace ConsoleTwitter.Entities
{
    public class User
    {
        public string Name { get; set; }
        public List<Message> _messages = new List<Message>();
        public List<User> _peopleFollowing = new List<User>(); 
    }
}
