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
            Darkness darkness = new Darkness("Kansas", 103, "Darkness");

            Console.WriteLine(Arus.Attack(11));
            Console.WriteLine(wizard.Attack(4));
            Console.WriteLine(darkness.Attack(7));
        }
    }
}
