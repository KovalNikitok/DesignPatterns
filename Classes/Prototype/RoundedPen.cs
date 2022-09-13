using System.Drawing;

namespace DesignPatterns.Classes.Prototype
{
    class RoundedPen : IPen
    {
        public bool IsClearable { get; private set; }
        private Color Color { get; set; }

        public RoundedPen(Color color, bool isClearable)
        {
            Color = color;
            IsClearable = isClearable;
        }
        public IPen Clone()
        {
            return new RoundedPen(Color, IsClearable);
        }

        public void GetColor()
        {
            System.Console.WriteLine($"{Color.Name} pen {(IsClearable ? "with eraser" : "")}");
        }
    }
}
