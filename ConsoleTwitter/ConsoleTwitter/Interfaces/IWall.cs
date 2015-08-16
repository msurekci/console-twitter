using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTwitter.Classes;

namespace ConsoleTwitter.Interfaces
{
    public interface IWall
    {
        List<Message> DisplayAllMessages(string username);
    }
}
