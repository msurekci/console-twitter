using System.Collections.Generic;
using ConsoleTwitter.Entities;

namespace ConsoleTwitter.Interfaces
{
    public interface IReading
    {
        List<Message> GetMessages(string username);
    }
}