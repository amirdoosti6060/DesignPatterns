namespace Bridge
{
    public class Radio : IDevice
    {
        public bool IsEnabled { get; private set; }
        public int Volume { get; set; }

        public void Enable()
        {
            IsEnabled = true;
            Console.WriteLine("Radio is enabled.");
        }

        public void Disable()
        {
            IsEnabled = false;
            Console.WriteLine("Radio is disabled.");
        }
    }
}
