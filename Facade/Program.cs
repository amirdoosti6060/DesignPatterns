using Facade;

Console.WriteLine("Facade Design Pattern (Structural Design Pattern)\n");

VideoConverter converter = new VideoConverter();
converter.Convert("input.avi", "output.mp4", "mp4");

