using System;
using System.Collections.Generic;
using ConsoleTwitter;
using ConsoleTwitter.Actions;
using ConsoleTwitter.Classes;
using ConsoleTwitter.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class WallTests
    {
        IWall _sut;
        IUserList _userList;

        [TestMethod]
        public void Must_display_all_messages_in_wall()
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
                                                   UsersMessage = "test1"
                                               }
                                           },
                               _peopleFollowing = new List<User>()
                                                  {
                                                      new User()
                                                      {
                                                          _messages = new List<Message>()
                                                                      {
                                                                          new Message()
                                                                          {
                                                                              UsersMessage = "test"
                                                                          }
                                                                      }
                                                      }
                                                  }
                           }
                       };
            _userList = new UserList();
            _userList.ListOfUsers = test;
            var username = "Alice";

            _sut = new Wall(_userList);

            var listOfMessages = _sut.DisplayAllMessages(username);
            
            Assert.AreEqual(listOfMessages.Count, 2);
        }
    }
}
