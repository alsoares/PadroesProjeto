using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance;

        public static Singleton GetInstance
        {
            get
            {
                if(instance is null)
                {
                    instance = new Singleton();
                    Console.WriteLine("Bola em jogo.");
                } 
                    return instance;
            }
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
        
    }
}