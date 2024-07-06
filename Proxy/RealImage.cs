namespace Proxy
{
    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine("Loading " + _fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying " + _fileName);
        }
    }
}
