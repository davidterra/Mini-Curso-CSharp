namespace Exemplo4
{
    public class StereoOffWithCdCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOffWithCdCommand(Stereo stereo)
        {
            this._stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
            
        }
    }
}
