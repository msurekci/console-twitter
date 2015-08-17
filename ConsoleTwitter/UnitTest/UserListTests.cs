using System;
using System.Collections.Generic;
using ConsoleTwitter;
using ConsoleTwitter.Entities;
using ConsoleTwitter.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UserListTests
    {
        IUserList _sut;

        [TestMethod]
        public void Add_user_to_list()
        {
            string username = "Alice";
            _sut = new UserList();

            _sut.AddUser(username);
            var countOfUsers = _sut.CountOfUsers();
            Assert.AreEqual(2, countOfUsers);
        }

        [TestMethod]
        public void Get_user_from_list()
        {
            var expectedUser = new User()
                               {
                                   Name = "Alice",
                                   _messages = new List<Message>()
                               };

            string username = "Alice";
            _sut = new UserList();

            _sut.AddUser(username);
            var user = _sut.GetUser(username);
            Assert.AreEqual(expectedUser.Name, user.Name);
        }
    }
}
