namespace Exemplo4
{
    public class CeilingFan 
    {
        private readonly string _text;

        public CeilingFan(string text)
        {
            this._text = text;
        }
        public void On()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("{0} ceiling fan is on high.", _text);
        }

        public void Off()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Gray;
            System.Console.WriteLine("{0} ceiling fan is off.", _text);
        }
    }
}
