namespace Gof.Graphic
{
    public class GraphicTool : Tool
    {
        public GraphicTool(Graphic graphic) : base(graphic)
        {
        }

        public override void Maniplate()
        {
            Console.WriteLine("--- GraphicTool Manipulate ---");
            Graphic graphic = (Graphic)prototype.Clone();
            graphic.Draw(new Position());
        }
    }
}
