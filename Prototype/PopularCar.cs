namespace Prototype
{
    public class PopularCar : ICar
    {
        public string Name { get; set; }
        public string  Color {get; set;}
        public int Year { get; set; }

        public ICar Clone()
        {
            return MemberwiseClone() as ICar;
        }

        public override string ToString()
        {
            return $"{Name} {Color} {Year}";
        }
    }
}