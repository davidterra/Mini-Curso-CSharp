namespace Exemplo4
{
    class Program
    {
        static void Main(string[] args)
        {

            // O Padrão Command encapsula uma solicitação como um objeto, o que lhe permite parametrizar outros objetos com diferentes solicitações,
            // enfileirar ou registrar solicitações e implementar recursos de cancelamento de operações.

            var remote = new SimpleRemoteControl();
            var light = new Light();

            var lightOnCommand = new LightOnCommand(light);

            remote.SetCommand(lightOnCommand);
            remote.ButtonWasPressed();

            // --
            //var remoteControl = new RemoteControl();
            //var livingRoomLigth = new Light("Living Room");
            //var kitchenLight = new Light("Kitchen");
            //var ceilingFan = new CeilingFan("Living Room");
            //var stereo = new Stereo("Living Room");

            //var livingRoomLightOn = new LightOnCommand(livingRoomLigth);
            //var livingRoomLightOff = new LightOffCommand(livingRoomLigth);

            //var kitchenLightOn = new LightOnCommand(kitchenLight);
            //var kitchenLightOff = new LightOffCommand(kitchenLight);

            //var ceilingFanOnCommand = new CeilingFanOnCommand(ceilingFan);
            //var ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

            //var stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            //var stereoOffWithCd = new StereoOffWithCdCommand(stereo);

            //remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            //remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            //remoteControl.SetCommand(2, ceilingFanOnCommand, ceilingFanOffCommand);
            //remoteControl.SetCommand(3, stereoOnWithCd, stereoOffWithCd);

            //System.Console.WriteLine(remoteControl.ToString());

            //remoteControl.OnButtonWasPushed(0);
            //remoteControl.OffButtonWasPushed(0);

            //remoteControl.OnButtonWasPushed(1);
            //remoteControl.OffButtonWasPushed(1);

            //remoteControl.OnButtonWasPushed(2);
            //remoteControl.OffButtonWasPushed(2);

            //remoteControl.OnButtonWasPushed(3);
            //remoteControl.OffButtonWasPushed(3);


            System.Console.ReadKey();
        }
    }
}
