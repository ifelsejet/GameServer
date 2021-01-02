using System;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game Server";
            Server.Start(50, 26590); //https://en.wikipedia.org/wiki/List_of_TCP_and_UDP_port_numbers
            Console.ReadKey();
        }
    }
}
