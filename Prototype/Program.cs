using Prototype;

Console.WriteLine("Prototype Design Pattern (Creational Design Pattern)");

// Create client instance
Client client = new Client();
client.DrawShapes();


// Client
public class Client
{
    public void DrawShapes()
    {
        // Create prototype instances
        IShape circlePrototype = new Circle { Radius = 10 };
        IShape rectanglePrototype = new Rectangle { Width = 20, Height = 30 };

        Console.WriteLine("\nDraw original shareps:");
        circlePrototype.Draw();
        rectanglePrototype.Draw();

        Console.WriteLine("\nClone original shares and draw newly created ones:");
        // Clone and draw shapes
        IShape clonedCircle = circlePrototype.Clone();
        clonedCircle.Draw();

        IShape clonedRectangle = rectanglePrototype.Clone();
        clonedRectangle.Draw();
    }
}
