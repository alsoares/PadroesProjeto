using System;
using System.Linq;
using System.Reflection;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public ICharacter ChooseCharacter(string name)
        {
           
            var type = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(x => x.GetInterfaces().Any(y => y.Name == "ICharacter") &&  x.Name == name)
            .FirstOrDefault();

            if(type is null) return default;


            return (ICharacter)Activator.CreateInstance(Type.GetType(type.FullName));

           

        }
    }
}