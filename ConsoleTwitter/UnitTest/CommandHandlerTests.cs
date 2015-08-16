using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using ConsoleTwitter;
using ConsoleTwitter.Actions;
using ConsoleTwitter.Classes;
using ConsoleTwitter.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace UnitTest
{
    [TestClass]
    public class CommandHandlerTests
    {
        CommandHandler _sut;
        IUserList userList;
        IPublish publish = Substitute.For<IPublish>();
        IReading reading = Substitute.For<IReading>();
        IFollow follow = Substitute.For<IFollow>();
        IWall wall = Substitute.For<IWall>();

        [TestMethod]
        public void Publish_message_should_be_called()
        {
            var test = new List<User>()
                       {
                           new User()
                           {
                               Name = "Alice"                               
                           }
                       };
            userList = new UserList();
            userList.ListOfUsers = test;

            _sut = new CommandHandler(userList, publish, reading, follow, wall);

            _sut.SelectAction("-> message", "Alice");

            publish.Received().PublishMessage("-> message", "Alice");           
        }


        [TestMethod]
        public void Must_be_able_to_see_own_messages()
        {
            var test = new List<User>()
                       {
                           new User()
                           {
                               Name = "Mahmut",
                               _messages = new List<Message>()
                                           {
                                               new Message()
                                               {
                                                   UsersMessage = "test",
                                                   messageDate = DateTime.Now
                                               },
                                               new Message()
                                               {
                                                   UsersMessage = "omg work! ... please"
                                               }
                                           }
                           }
                       };
            userList = new UserList();
            userList.ListOfUsers = test;

            _sut = new CommandHandler(userList, publish, reading, follow, wall);

            _sut.SelectAction("my messages", "Mahmut");

            reading.Received().GetMessages("Mahmut");
        }

        [TestMethod]
        public void Must_follow_a_user()
        {
            var test = new List<User>()
                       {
                           new User()
                           {
                               Name = "Alice"                               
                           }
                       };
            userList = new UserList();
            userList.ListOfUsers = test;

            _sut = new CommandHandler(userList, publish, reading, follow, wall);

            _sut.SelectAction("follow Mahmut", "Alice");

            follow.Received().FollowUser("Alice", "Mahmut");
        }

        [TestMethod]
        public void Must_show_all_messages()
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
                                           },
                               _peopleFollowing = new List<User>()
                                                  {
                                                      new User()
                                                      {
                                                          Name = "Mahmut",
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
            userList = new UserList();
            userList.ListOfUsers = test;

            _sut = new CommandHandler(userList, publish, reading, follow, wall);

            _sut.SelectAction("wall", "Alice");

            wall.Received().DisplayAllMessages("Alice");
        }
    }
}
