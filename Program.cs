using System;
using dotnet_poo.src.Entities;

namespace dotnet_poo
{
      class Program
      {
            static void Main(string[] args)
            {
                  Knight arus = new Knight("Arus", 42, "Knight");
                  Wizard jennica = new Wizard("Jennica", 42, "White Wizard");
                  Ninja wedge = new Ninja("Wedge", 42, "Ninja");
                  Wizard topapa = new Wizard("Topapa", 42, "Black Wizard");
                  Console.WriteLine(arus.Attack(5));
                  Console.WriteLine(jennica.Attack(45));
                  Console.WriteLine(wedge.Attack(20));
                  Console.WriteLine(topapa.Attack());
            }
      }
}