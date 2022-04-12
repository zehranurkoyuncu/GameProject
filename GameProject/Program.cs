using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Gamer{ BirthYear= 0000, FirstName = "Name", LastName = "Surname",
                IdentityNo = 11111111111 });
            Console.ReadLine();

        }
    }
}
