namespace Bridge
{
    public interface IDevice
    {
        bool IsEnabled { get; }
        int Volume { get; set; }
        void Enable();
        void Disable();
    }
}
