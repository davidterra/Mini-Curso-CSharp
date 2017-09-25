namespace Exemplo4
{
    public class CeilingFanOnCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _ceilingFan.On();
        }
    }
}
