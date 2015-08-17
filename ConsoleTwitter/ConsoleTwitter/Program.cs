using System;
using ConsoleTwitter.Actions;
using ConsoleTwitter.Interfaces;

namespace ConsoleTwitter
{
    public class Program
    {
        static IUserList userList = new UserList();
        static IPublish publish = new Publish(userList);
        static IReading reading = new Reading(userList);
        static IFollow follow = new Follow(userList);
        static IWall wall = new Wall(userList);

        public static void Main()
        {
            Console.WriteLine(">");
            Console.Write("Enter username: ");
            var userName = Console.ReadLine();
            userList.AddUser(userName);

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {                
                Console.WriteLine("Enter command: ");
                Console.Write(userName + " ");
                var command = Console.ReadLine();                

                var commandHandler = new CommandHandler(userList, publish, reading, follow, wall);

                commandHandler.SelectAction(command, userName);
            }
        }
    }
}