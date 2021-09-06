using System;

namespace ConsoleApp
{
    public class Pardal : Animal
    {
        public override void Falar()
        {
            Console.WriteLine("Piar!");
        }
        
        /*
        public override void Locomover()
        {
            // executa método da classe pai
            base.Locomover();

            // nova adicao no método
            Console.WriteLine("Passarinho voando!");
        }
        */
    }
}