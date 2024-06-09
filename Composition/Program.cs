using Directory = Composition.Directory;
using File = Composition.File;

Console.WriteLine("Composition Design Pattern (Structural Design Pattern)");

Directory root = new Directory("root");
root.Add(new File("file1.txt"));
root.Add(new File("file2.txt"));

Directory subDir = new Directory("subdir");
subDir.Add(new File("file3.txt"));
root.Add(subDir);

root.Display(1);
