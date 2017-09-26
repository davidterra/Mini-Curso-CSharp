using System;

namespace Exemplo6
{
    public class Projector
    {
        internal void On()
        {
            System.Console.WriteLine("Top-O-Line Projector On.");
        }

        internal void WideScreenMode()
        {
            System.Console.WriteLine("Top-O-Line Projector in widescreen mode (16x9 aspect ratio).");
        }

        internal void Off()
        {
            System.Console.WriteLine("Top-O-Line Projector Off.");
        }
    }
}