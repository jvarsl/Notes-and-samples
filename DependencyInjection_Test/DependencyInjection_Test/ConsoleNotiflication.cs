using System;

namespace DependencyInjection_Test
{
    internal class ConsoleNotiflication : INotiflicationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Username changed to {user.Username}");
        }

    }
}