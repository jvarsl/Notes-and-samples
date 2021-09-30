using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();

        private List<string> servers = new List<string>();
        private int nextServer = 0;

        private TableServers()
        {
            servers.Add("Tim");
            servers.Add("Sue");
            servers.Add("Mary");
            servers.Add("Bob");
        }

        public static TableServers GetTableServers()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = servers[nextServer];
            nextServer++;
            if (nextServer >= servers.Count) nextServer = 0;

            return output;

        }
    }
}
