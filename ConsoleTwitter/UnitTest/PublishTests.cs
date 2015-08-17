using ConsoleTwitter;
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

        [TestMethod]
        public void Must_be_able_to_publish_a_message()
        {
            _userList = new UserList();
            _userList.AddUser("Alice");
            _sut = new Publish(_userList);

            _sut.PublishMessage(usersMessage, "Alice");

            var user = _userList.GetUser("Alice");
            Assert.AreEqual(user._messages.Count, 1);
        }
    }
}
