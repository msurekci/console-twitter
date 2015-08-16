
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTwitter.Actions;
using ConsoleTwitter.Interfaces;

namespace ConsoleTwitter
{
    public class CommandHandler
    {
        readonly IUserList _userList;
        readonly IPublish _publish;
        readonly IReading _reading;
        readonly IFollow _follow;
        readonly IWall _wall;

        public CommandHandler(IUserList userList, IPublish publish, IReading reading, IFollow follow, IWall wall)
        {
            _userList = userList;
            _publish = publish;
            _reading = reading;
            _follow = follow;
            _wall = wall;
        }

        public void SelectAction(string command, string userName)
        {
            if (command.Contains("->"))
            {
                _publish.PublishMessage(command, userName);
            }

            if (command.Contains("my messages"))
            {
                var listOfMessages = _reading.GetMessages(userName);

                foreach (var message in listOfMessages)
                {
                    Console.WriteLine(message.UsersMessage);
                }
            }

            if (command.Contains("wall"))
            {
                var listOfMessages = _wall.DisplayAllMessages(userName);

                foreach (var message in listOfMessages)
                {
                    Console.WriteLine(message.UsersMessage + " posted on: " + message.messageDate);
                }
            }

            if (command.Contains("follow"))
            {
                var personToFollow = command.Substring(7);
                _follow.FollowUser(userName, personToFollow);
            }
        }
    }
}
