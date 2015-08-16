using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTwitter;
using ConsoleTwitter.Actions;
using ConsoleTwitter.Classes;
using ConsoleTwitter.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace UnitTest
{
    [TestClass]
    public class ReadingTests
    {
        IReading _sut;
        IUserList _userList;
        IPublish _publish;

        [TestMethod]
        public void Get_all_messages_of_user()
        {
            var test = new List<User>()
                       {
                           new User()
                           {
                               Name = "Alice",
                               _messages = new List<Message>()
                                           {
                                               new Message()
                                               {
                                                   UsersMessage = "test"
                                               }
                                           }
                           }
                       };
            _userList = new UserList();
            _userList.ListOfUsers = test;
                                            
            _sut = new Reading(_userList);
            var messageList = _sut.GetMessages("Alice");   
            var firstMessage = messageList.FirstOrDefault();

            Assert.AreEqual(firstMessage.UsersMessage, "test");
        }
    }
}
