using System;

namespace ConsoleApp
{
    public abstract class Animal
    {
        public abstract void Falar();

        public void Dormir(){
            // pega o tipo da classe
            Console.WriteLine(this.GetType().Name + " Dormindo...");
        }
    }
}