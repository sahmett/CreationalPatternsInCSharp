namespace Gof.Graphic
{
    public class Staff : Graphic
    {
        private readonly string property;

        public Staff(string name, string property) : base(name)
        {
            this.property = property;
        }

        public override void Draw(Position position)
        {
            Console.WriteLine($"Drawing Staff: {name} (Property: {property})");
        }

        public override Graphic Clone()
        {
            Console.WriteLine($"Cloning Staff: {name}");
            return new Staff(name, property);
        }
    }
}
