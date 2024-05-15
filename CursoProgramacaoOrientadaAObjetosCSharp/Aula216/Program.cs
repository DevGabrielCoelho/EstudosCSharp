using Entities;
using System;

namespace Aula216
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>();
            clients.Add(new Client("Maria","maria@mail.com"));
            clients.Add(new Client("Alex","alex@mail.com"));
            clients.Add(new Client("MariaClara","maria@mail.com"));
            Console.WriteLine(clients[0].Equals(clients[1]));
            Console.WriteLine(clients[0].Equals(clients[2]));
            Console.WriteLine(clients[1].Equals(clients[0]));
            Console.WriteLine(clients[1].Equals(clients[2]));
            Console.WriteLine(clients[2].Equals(clients[0]));
            Console.WriteLine(clients[2].Equals(clients[1]));
            Console.WriteLine(clients[0].GetHashCode());
            Console.WriteLine(clients[1].GetHashCode());
            Console.WriteLine(clients[2].GetHashCode());
        }
    }
}