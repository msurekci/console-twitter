﻿using ConsoleTwitter.Entities;

namespace ConsoleTwitter.Interfaces
{
    public interface IPublish
    {
        void PublishMessage(string userMessage, string username);

        void SaveMessage(Message formattedMessage, string username);
    }
}