namespace Exemplo4
{
    public class Light
    {
        private readonly string _text;

        public Light() { }

        public Light(string text)
        {
            this._text = text;
        }
        public void On()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("{0} light is on.", _text);
        }

        public void Off()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Gray;
            System.Console.WriteLine("{0} light is off.", _text);
        }
    }
}
