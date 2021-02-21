using GameSellerDemo.Concrete;
using GameSellerDemo.Entities;
using System;

namespace GameSellerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            Gamer gamer1 = new Gamer();
            gamer1.GamerID = 1234;
            gamer1.Name = "Melih";
            gamer1.Surname = "Sivri";
            gamer1.NationalID = 123123123;
            gamer1.DateOfBirth = 123123;
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Update(gamer1);
        }
    }
}
