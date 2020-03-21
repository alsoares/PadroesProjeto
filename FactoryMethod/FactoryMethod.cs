namespace FactoryMethod
{
    public class FactoryMethod
    {
        public ICharacter ChooseCharacter(string name)
        {
            switch (name)
            {
                case "SubZero": return new SubZero();
                case "Scorpion": return new Scorpion();
                default: return default;
            }
        }
    }
}