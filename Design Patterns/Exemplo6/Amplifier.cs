using System;

namespace Exemplo6
{
    public class Amplifier
    {
        internal void On()
        {
            System.Console.WriteLine("Top-O-Line Amplifier On.");
        }

        internal void SetDvd(DvdPlayer _dvd)
        {
            System.Console.WriteLine("Top-O-Line Amplifier setting DVD Player to Top-O-Line DVD Player.");
        }

        internal void SetSurroundSound()
        {
            System.Console.WriteLine("Top-O-Line Amplifier surround sound on (5 speakers, 1 subwoofer).");
        }

        internal void SetVolume(int value)
        {
            System.Console.WriteLine("Top-O-Line Amplifier setting volume to {0}.", value);
        }

        internal void Off()
        {
            System.Console.WriteLine("Top-O-Line Amplifier Off.");
        }
    }
}