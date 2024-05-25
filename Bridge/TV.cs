namespace Bridge
{
    public class TV : IDevice
    {
        public bool IsEnabled { get; private set; }
        public int Volume { get; set; }

        public void Enable()
        {
            IsEnabled = true;
            Console.WriteLine("TV is enabled.");
        }

        public void Disable()
        {
            IsEnabled = false;
            Console.WriteLine("TV is disabled.");
        }
    }
}
