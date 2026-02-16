namespace Gof.Graphic
{
    public class RotateTool : Tool
    {
        public RotateTool(Graphic prototype) : base(prototype)
        {
        }

        public override void Maniplate()
        {
            Console.WriteLine("--- RotateTool Manipulate ---");
            Graphic graphic = (Graphic)prototype.Clone();
            graphic.Draw(new Position());
        }
    }
}
