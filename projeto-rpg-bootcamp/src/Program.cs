using System;
using projeto_rpg_bootcamp.Entities;
using projeto_rpg_bootcamp.src.Entities;

namespace projeto_rpg_bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Darkness Kansas = new Darkness("Kansas", 103, "Kansas");

            Console.WriteLine(Arus.Attack(10));
            Console.WriteLine(wizard.Attack(4));
            Console.WriteLine(Kansas.Attack(7));
        }
    }
}
