using Proxy;

Console.WriteLine("Flyweight Design Pattern (Structural Design Pattern)\n");

IImage image = new ProxyImage("test_image.jpg");

// Image will be loaded from disk
image.Display();

// Image will not be loaded from disk
image.Display();
