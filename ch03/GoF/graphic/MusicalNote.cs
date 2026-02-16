namespace Gof.Graphic
{
    public class MusicalNote : Graphic
    {
        private readonly string note;
        private readonly int octave;
        private readonly int duration;

        public MusicalNote(string name, string note, int octave, int duration) : base(name)
        {
            this.note = note;
            this.octave = octave;
            this.duration = duration;
        }

        public override void Draw(Position position)
        {
            Console.WriteLine($"Drawing {GetType().Name}: {name} (Note: {note}, Octave: {octave}, Duration: {duration})");
        }

        public override Graphic Clone()
        {
            Console.WriteLine($"Cloning {GetType().Name}: {name}");
            return new MusicalNote(name, note, octave, duration);
        }
    }
}
