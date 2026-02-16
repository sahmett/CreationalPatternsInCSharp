using Gof.Graphic;

namespace GoF;

public class Test
{
    private static void Main()
    {
        // Prototip nesneleri oluştur
        Graphic musicalNote = new MusicalNote("Do Notası", "C", 4, 500);
        Graphic halfNote = new HalfNote("Yarım Nota", "E", 3, 250);
        Graphic wholeNote = new WholeNote("Tam Nota", "G", 5, 1000);
        Graphic staff = new Staff("Sol Anahtarı", "Treble Clef");

        // Prototipleri klonlayarak Tool üzerinden kullan
        GraphicTool noteTool = new GraphicTool(musicalNote);
        noteTool.Maniplate();

        GraphicTool halfNoteTool = new GraphicTool(halfNote);
        halfNoteTool.Maniplate();

        RotateTool rotateTool = new RotateTool(wholeNote);
        rotateTool.Maniplate();

        GraphicTool staffTool = new GraphicTool(staff);
        staffTool.Maniplate();
    }
}