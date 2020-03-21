using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factory = new FactoryMethod();

            var character = factory.ChooseCharacter("SubZero");

            character.Chosen();

        }
    }
}
