namespace Exemplo4
{
    public class RemoteControl
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            var noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();

            sb.Append("\n----- Remote Control -----\n");

            for (int i = 0; i < _onCommands.Length; i++)
            {
                sb.AppendFormat("[slot {0} ] ON: {1} \t OFF: {2} \n", i, _onCommands[i].GetType().Name, _offCommands[i].GetType().Name);
            }

            return sb.ToString();
        }
    }
}
