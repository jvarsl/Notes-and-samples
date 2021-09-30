using System;

namespace SingletonDemo
{
    class Program
    {
        static TableServers host1List = TableServers.GetTableServers();
        static TableServers host2List = TableServers.GetTableServers();
        static void Main(string[] args)
        {
            var servers = TableServers.GetTableServers();

            for (int i = 0; i < 5; i++)
            {
                Host1GetNextServer();
                Host2GetNextServer();
            }
        }


        private static void Host1GetNextServer()
        {
            Console.WriteLine(host1List.GetNextServer());
        }
        private static void Host2GetNextServer()
        {
            Console.WriteLine(host2List.GetNextServer());
        }
    }
}
