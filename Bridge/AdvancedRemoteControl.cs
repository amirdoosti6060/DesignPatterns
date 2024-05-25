namespace Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public void Mute()
        {
            _device.Volume = 0;
            Console.WriteLine("Volume is muted.");
        }
    }
}
