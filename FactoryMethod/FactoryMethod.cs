using System;
using System.Linq;
using System.Reflection;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public ICharacter ChooseCharacter(string name)
        {
            // switch (name)
            // {
            //     case "SubZero": return new SubZero();
            //     case "Scorpion": return new Scorpion();
            //     default: return default;
            // }

            var type = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(x => x.GetInterfaces().Any(y => y.Name == "ICharacter") &&  x.Name == name)
            .FirstOrDefault();

            return (ICharacter)Activator.CreateInstance(Type.GetType(type.FullName));

           

        }
    }
}