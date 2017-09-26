using System;

namespace Exemplo6
{
    public class TheaterLigths
    {
        internal void Dim(int value)
        {
            System.Console.WriteLine("Theater Ceiling Lights dimming to {0}%.", value);
        }

        internal void On()
        {
            System.Console.WriteLine("Theater Ceiling Lights On.");
        }
    }
}