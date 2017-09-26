using System;

namespace Exemplo6
{
    public class DvdPlayer
    {
        internal void On()
        {
            System.Console.WriteLine("Top-O-Line DVD Player On.");
        }

        internal void Play(string movie)
        {
            System.Console.WriteLine("Top-O-Line DVD Player playing \"{0}\".", movie);
        }

        internal void Stop(string movie)
        {
            System.Console.WriteLine("Top-O-Line DVD Player stopped \"{0}\".", movie);
        }

        internal void Eject()
        {
            System.Console.WriteLine("Top-O-Line DVD Player eject.");
        }

        internal void Off()
        {
            System.Console.WriteLine("Top-O-Line DVD Player Off.");
        }
    }
}