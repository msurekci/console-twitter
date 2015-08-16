using System;
using ConsoleTwitter.Classes;
using ConsoleTwitter.Interfaces;

namespace ConsoleTwitter.Actions
{
    public class Publish : IPublish
    {
        readonly IUserList _userList;

        public Publish(IUserList userList)
        {
            _userList = userList;
        }

        public void PublishMessage(string userMessage, string username)
        {
            var formattedMessage = new Message()
                                   {
                                       messageDate = DateTime.Now, 
                                       UsersMessage = userMessage
                                   };
            SaveMessage(formattedMessage, username);
        }

        public void SaveMessage(Message formattedMessage, string username)
        {
            var user = this._userList.GetUser(username);
            user._messages.Add(formattedMessage);
        }
    }
}