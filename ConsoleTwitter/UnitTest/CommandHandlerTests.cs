using System;
using System.Collections.Generic;
using ConsoleTwitter;
using ConsoleTwitter.Entities;
using ConsoleTwitter.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace UnitTest
{
    [TestClass]
    public class CommandHandlerTests
    {
        CommandHandler _sut;
        IUserList userList = Substitute.For<IUserList>();
        IPublish publish = Substitute.For<IPublish>();
        IReading reading = Substitute.For<IReading>();
        IFollow follow = Substitute.For<IFollow>();
        IWall wall = Substitute.For<IWall>();

        [TestMethod]
        public void Publish_message_should_be_called()
        {
            _sut = new CommandHandler(userList, publish, reading, follow, wall);

            _sut.SelectAction("-> message", "Alice");

            publish.Received().PublishMessage("-> message", "Alice");           
        }


        [TestMethod]
        public void Must_be_able_to_see_own_messages()
        {

            reading.GetMessages("Mahmut").Returns(new List<Message>()
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
                                           });

            _sut = new CommandHandler(userList, publish, reading, follow, wall);

            _sut.SelectAction("my messages", "Mahmut");

            reading.Received().GetMessages("Mahmut");
        }

        [TestMethod]
        public void Must_follow_a_user()
        {
            _sut = new CommandHandler(userList, publish, reading, follow, wall);

            _sut.SelectAction("follow Mahmut", "Alice");

            follow.Received().FollowUser("Alice", "Mahmut");
        }

        [TestMethod]
        public void Must_show_all_messages()
        {            
            wall.DisplayAllMessages("Alice").Returns(new List<Message>()
                                           {
                                               new Message()
                                               {
                                                   UsersMessage = "test"
                                               }
                                           });

            _sut = new CommandHandler(userList, publish, reading, follow, wall);

            _sut.SelectAction("wall", "Alice");

            wall.Received().DisplayAllMessages("Alice");
        }
    }
}
