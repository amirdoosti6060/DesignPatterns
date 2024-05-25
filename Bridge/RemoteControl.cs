namespace Bridge
{
    public class RemoteControl: IRemoteControl
    {
        protected IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TogglePower()
        {
            if (_device.IsEnabled)
            {
                _device.Disable();
            }
            else
            {
                _device.Enable();
            }
        }

        public void VolumeUp()
        {
            _device.Volume += 10;
            Console.WriteLine($"Volume is now {_device.Volume}");
        }

        public void VolumeDown()
        {
            _device.Volume -= 10;
            Console.WriteLine($"Volume is now {_device.Volume}");
        }
    }
}
