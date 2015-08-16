using System.Collections.Generic;
using ConsoleTwitter.Classes;

namespace ConsoleTwitter.Interfaces
{
    public interface IReading
    {
        List<Message> GetMessages(string username);
    }
}