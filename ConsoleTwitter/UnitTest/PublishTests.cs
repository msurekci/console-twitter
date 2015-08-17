﻿using ConsoleTwitter;
using ConsoleTwitter.Actions;
using ConsoleTwitter.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class PublishTests
    {
        const string usersMessage = "I love the weather today";
        IPublish _sut;
        IUserList _userList;

        // public IUserList FakeData()
        // {
        // var userList = new List<User>
        // {
        // new User()
        // {
        // Name = "Alice",
        // _messages = new List<Message>()
        // }
        // };

        // var context = Substitute.For<IUserList>();
        // context.ListOfUsers.Returns(userList);

        // return context;
        // }
        [TestMethod]
        public void Must_be_able_to_publish_a_message()
        {
            // var fakeUserList = FakeData();
            _userList = new UserList();
            _userList.AddUser("Alice");
            _sut = new Publish(_userList);

            _sut.PublishMessage(usersMessage, "Alice");

            var user = _userList.GetUser("Alice");
            Assert.AreEqual(user._messages.Count, 1);
        }
    }
}