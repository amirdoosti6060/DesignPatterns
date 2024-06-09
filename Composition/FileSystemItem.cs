namespace Composition
{
    public abstract class FileSystemItem
    {
        public string Name { get; protected set; }

        public FileSystemItem(string name)
        {
            Name = name;
        }

        public abstract void Display(int depth);
    }
}
