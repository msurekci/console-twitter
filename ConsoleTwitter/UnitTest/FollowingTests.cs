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
    public class FollowingTests
    {
        IFollow _sut;
        IUserList _userList;

        [TestMethod]
        public void Must_be_able_to_follow_another_user()
        {
            var test = new List<User>()
                       {
                           new User()
                           {
                               Name = "Alice",
                               _peopleFollowing = new List<User>()
                           }
                       };
            _userList = new UserList();
            _userList.ListOfUsers = test;

            var username = "Alice";
            var usernameOfFollowed = "Bob";

            _sut = new Follow(_userList);

            _sut.FollowUser(username, usernameOfFollowed);

            var user = test.Find(u => u.Name == username);
            Assert.AreEqual(user._peopleFollowing.Count, 1);
        }
    }
}
