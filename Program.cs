using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // ctrl + . -> opções de auto-completar ou solucionar
            /*
            Animal animal = new Cachorro();

            animal.Locomover();
            animal.Falar();
            animal.Dormir();

            animal = new Pardal();

            animal.Locomover();
            animal.Falar();
            animal.Dormir();
            */

            IMamifero animal = new Cachorro();
        }
    }
}
