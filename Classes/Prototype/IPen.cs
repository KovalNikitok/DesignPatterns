using System.Drawing;

namespace DesignPatterns.Classes.Prototype
{
    interface IPen
    {
        IPen Clone();
        void GetColor();
    }
}
