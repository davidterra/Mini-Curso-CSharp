namespace Exemplo4
{
    public class Stereo
    {
        private readonly string _text;

        public Stereo(string text)
        {
            this._text = text;
        }

        public void On()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("{0} stereo is on.", _text);
        }

        public void SetCd()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
            System.Console.WriteLine("{0} stereo is set for CD input.", _text);

        }

        public void SetVolume(int value)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine("{0} stereo volume set to {1}.", _text, value);
        }

        public void Off()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Gray;
            System.Console.WriteLine("{0} stereo is off.", _text);
        }
    }
}
