using System.Drawing;

namespace DesignPatterns.Classes.Prototype
{
    class LongPen : IPen
    {
        private Color Color { get; set; }

        public LongPen(Color color)
        {
            Color = color;
        }

        public void GetColor()
        {
            System.Console.WriteLine(Color.Name);
        }

        public IPen Clone() => new LongPen(Color);
    }
}
