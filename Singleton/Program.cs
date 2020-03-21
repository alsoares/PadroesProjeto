using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var ronaldo = Singleton.GetInstance;
            var ronaldinho = Singleton.GetInstance;
            var rivaldo = Singleton.GetInstance;

            ronaldinho.Message("Ronaldinho dominou a bola..");
            rivaldo.Message("Rivaldo recebe a bola e lança..");
            ronaldo.Message("Ronaldo marca o gol");
            
        }
    }
}
